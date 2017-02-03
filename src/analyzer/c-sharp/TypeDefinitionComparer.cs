﻿using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protoextractor.analyzer.c_sharp
{
    // Create a compare function so our dictionaries won't contain multiple TypeDefinitions for the same type
    class TypeDefinitionComparer : IEqualityComparer<TypeDefinition>
    {
        // The purpose is to match equality solely by FullName of the type.
        // This means comparing both FullName's and delegating the hash function for string.
        public bool Equals(TypeDefinition x, TypeDefinition y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null | y == null)
                return false;
            else
                return x.FullName.Equals(y.FullName);
        }

        public int GetHashCode(TypeDefinition obj)
        {
            return obj.FullName.GetHashCode();
        }
    }
}
