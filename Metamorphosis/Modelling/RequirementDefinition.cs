﻿using System.Reflection;

namespace Metamorphosis.Modelling
{
    internal class RequirementDefinition
    {
        public MethodInfo ReceiverMethod { get; set; }
        public string Sender { get; set; }
        public string Capability { get; set; }
    }
}