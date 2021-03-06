﻿using DotNetCore.CAP.Abstractions;
using DotNetCore.CAP.Models;

namespace DotNetCore.CAP.Internal
{
    public class DefaultMessagePacker : IMessagePacker
    {
        private readonly IContentSerializer _serializer;

        public DefaultMessagePacker(IContentSerializer serializer)
        {
            _serializer = serializer;
        }

        public string Pack(CapMessage obj)
        {
            return _serializer.Serialize(obj);
        }

        public CapMessage UnPack(string packingMessage)
        {
            return _serializer.DeSerialize<CapMessageDto>(packingMessage);
        }
    }
}
