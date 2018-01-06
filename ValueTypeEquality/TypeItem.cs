using System;
using System.Collections.Generic;
using System.Text;

namespace ValueTypeEquality
{
    public enum ValueType
    {
        Bool, Char, Byte, Sbyte, Int, Uint, Short, Ushort,
        Long, Ulong, Float, Double, Decimal, Struct, Enum
    }

    public struct TypeItem : IEquatable<TypeItem>
    {
        private readonly string _name;
        private readonly ValueType _type;

        public string Name { get { return _name; } }
        public ValueType Type { get { return _type; } }

        public TypeItem(string name, ValueType type)
        {
            this._name = name;
            this._type = type;
        }

        public override string ToString()
        {
            return _name;
        }

        public bool Equals(TypeItem other)
        {
            return this._name == other.Name && this._type == other.Type;
        }

        public override bool Equals(object obj)
        {
            if (obj is TypeItem)
                return Equals((TypeItem)obj);
            else
                return false;
        }

        public static bool operator ==(TypeItem lhs, TypeItem rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator != (TypeItem lhs, TypeItem rhs)
        {
            return !lhs.Equals(rhs);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _type.GetHashCode();
        }
    }
}
