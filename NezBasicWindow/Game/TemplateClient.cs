using System;
using System.Collections.Generic;
using System.Text;
using Nez;

namespace FNATemplate.Game
{
    class TemplateClient : Core
    {
        public TemplateClient() : base()
        { }

        override protected void Initialize()
        {
            base.Initialize();

            Scene = new Scene();
        }
    }
}
