﻿using System;
using System.Collections.Generic;

namespace Build
{
    public abstract class RuntimeAttribute : Attribute, IRuntimeAttribute 
    {
        IDictionary<string, IRuntimeAttribute> _runtimeTypes = new Dictionary<string, IRuntimeAttribute>();
        public Guid Guid { get; } = Guid.NewGuid();
        public Type Type { get; protected set; }
        public abstract RuntimeInstance Runtime { get; }
        public string RuntimeTypeId { get; protected set; }
        public void RegisterRuntimeType(string typeId, IRuntimeAttribute runtimeType) => _runtimeTypes[typeId] = runtimeType;
        public IRuntimeAttribute GetRuntimeType(string typeId)
        {
            if (!_runtimeTypes.ContainsKey(typeId))
            {
                return this;
            }
            return _runtimeTypes[typeId];
        }
    }
}
