using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Checker
{
    internal class Program
    {
        private string _root = string.Empty;
        private string _version = string.Empty;
        private string _description = string.Empty;
        private List<string> _direcs = new List<string>();

        private void SetRoot()
        {
            _root = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            _root = Path.Combine(_root, @"..\..\..\..");
            _root = Path.GetFullPath(_root);
        }

        private void GetDirecs()
        {
            foreach (var direc in Directory.GetDirectories(_root))
            {
                var sub = direc.Substring(_root.Length + 1);
                if (sub.Length < 8 || sub.Substring(0, 8) != "Bugbear." || sub.Contains(".Tests"))
                    continue;

                _direcs.Add(sub);
            }
        }

        private string Proj(string sub)
        {
            return Path.Combine(Path.Combine(_root, sub), $"{sub}.csproj");
        }

        private static void SelectNodes(XmlElement? root, string name, List<XmlElement> list)
        {
            foreach (var node in root!.ChildNodes)
            {
                if (node!.GetType() != typeof(XmlElement))
                {
                    continue;
                }

                var element = node as XmlElement;
                if (element?.Name == name)
                {
                    list.Add(element);
                }
                else
                {
                    SelectNodes(element, name, list);
                }
            }
        }

        private bool GetVersion()
        {
            var proj = Proj("Bugbear.Core");
            var doc = new XmlDocument();
            doc.Load(proj);
            var root = doc.DocumentElement;

            var packages = new List<XmlElement>();
            SelectNodes(root, "PackageReference", packages);
            foreach (var package in packages)
            {
                var include = package.GetAttribute("Include");
                if (include != "Gremlin.Net")
                    continue;

                _version = package.GetAttribute("Version");
                _description = $"Bugbear is a wrapper library for Gremlin.Net {_version}.";
                _version = _version.Replace(".", string.Empty);
                _version = $".{_version}.";
                break;
            }

            var versions = new List<XmlElement>();
            SelectNodes(root, "Version", versions);
            foreach (var version in versions)
            {
                var text = version.FirstChild.Value;
                if (!text.Contains(_version))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Version {text} does not contain {_version}");
                }
                else
                {
                    _version = text;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Version is {text}");
                    return true;
                }
            }

            return false;
        }

        private bool Validate(string sub)
        {
            var validated = true;
            var proj = Proj(sub);
            var doc = new XmlDocument();
            doc.Load(proj);
            var root = doc.DocumentElement;

            var versions = new List<XmlElement>();
            SelectNodes(root, "Version", versions);
            foreach (var version in versions)
            {
                var text = version.FirstChild.Value;
                if (text != _version)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{sub} has version {text} not {_version}");
                    validated = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"{sub} has version {text}");
                }
            }

            var descriptions = new List<XmlElement>();
            SelectNodes(root, "Description", descriptions);
            foreach (var description in descriptions)
            {
                var text = description.FirstChild.Value;
                if (text.IndexOf(_description) != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    validated = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine($"{sub} has description {text}");
            }

            return validated;
        }

        private bool Validate()
        {
            var validated = true;
            foreach (var sub in _direcs)
            {
                if (!Validate(sub))
                {
                    validated = false;
                }
            }

            return validated;
        }

        static int Main(string[] args)
        {
            var program = new Program();
            program.SetRoot();
            program.GetDirecs();
            if (!program.GetVersion() || !program.Validate())
            {
                return 1;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            return 0;
        }
    }
}
