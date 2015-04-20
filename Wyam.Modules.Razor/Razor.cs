﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wyam.Core;
using Wyam.Core.Modules;

namespace Wyam.Modules.Razor
{
    public class Razor : IModule
    {
        private readonly ReadFiles _readFile;

        public Razor()
        {
        }

        // Use this constructor to read file(s) for input
        // It has the effect of inserting a ReadFiles module into the pipeline just before this module
        public Razor(Func<IMetadata, string> files)
        {
            _readFile = new ReadFiles(files);
        }

        public IEnumerable<IPipelineContext> Prepare(IPipelineContext context)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public string Execute(IPipelineContext context, string content)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}