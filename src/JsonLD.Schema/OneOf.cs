// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace JsonLD.Schema
{
    /// <summary>
    /// Defines the required contract for implementing a discriminating union.
    /// </summary>
    public interface IOneOf
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        object Value { get; }
    }

    /// <summary>
    /// Represents a discriminating union of two types
    /// </summary>
    /// <typeparam name="T0">The first type.</typeparam>
    /// <typeparam name="T1">The second type.</typeparam>
    public struct OneOf<T0, T1> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly int _index;

        /// <summary>
        /// Initialises a new instance of <see cref="OneOf{T0, T1}"/>
        /// </summary>
        /// <param name="value">The value of the first type.</param>
        public OneOf(T0 value)
        {
            _value0 = value;
            _index = 0;

            _value1 = default(T1);
        }
        
        /// <summary>
        /// Initialises a new instance of <see cref="OneOf{T0, T1}"/>
        /// </summary>
        /// <param name="value">The value of the second type.</param>
        public OneOf(T1 value)
        {
            _value1 = value;
            _index = 1;

            _value0 = default(T0);
        }

        /// <summary>
        /// Gets the value of the first type.
        /// </summary>
        public T0 AsValue0 => _value0;

        /// <summary>
        /// Gets the value of the second type.
        /// </summary>
        public T1 AsValue1 => _value1;

        /// <summary>
        /// Gets whether the union value is of the first type.
        /// </summary>
        public bool IsT0 => (_index == 0);

        /// <summary>
        /// Gets whether the union value is of the second type.
        /// </summary>
        public bool IsT1 => (_index == 1);

        /// <summary>
        /// Provides an implicit conversion from a <see cref="T0"/> to a <see cref="OneOf{T0, T1}"/>
        /// </summary>
        /// <param name="value">The value of the first type.</param>
        public static implicit operator OneOf<T0, T1>(T0 value)
            => new OneOf<T0, T1>(value);

        /// <summary>
        /// Provides an implicit conversion from a <see cref="T1"/> to a <see cref="OneOf{T0, T1}"/>
        /// </summary>
        /// <param name="value">The value of the second type.</param>
        public static implicit operator OneOf<T0, T1>(T1 value)
            => new OneOf<T0, T1>(value);

        /// <inheritdoc />
        object IOneOf.Value => IsT0 ? (object)_value0 : _value1;
    }

    /// <summary>
    /// Represents a discriminating union of two types
    /// </summary>
    /// <typeparam name="T0">The first type.</typeparam>
    /// <typeparam name="T1">The second type.</typeparam>
    /// <typeparam name="T2">The third type.</typeparam>
    public struct OneOf<T0, T1, T2> : IOneOf
    {
        private readonly T0 _value0;
        private readonly T1 _value1;
        private readonly T2 _value2;
        private readonly int _index;

        /// <summary>
        /// Initialises a new instance of <see cref="OneOf{T0, T1, T2}"/>
        /// </summary>
        /// <param name="value">The value of the first type.</param>
        public OneOf(T0 value)
        {
            _value0 = value;
            _index = 0;

            _value1 = default(T1);
            _value2 = default(T2);
        }

        /// <summary>
        /// Initialises a new instance of <see cref="OneOf{T0, T1, T2}"/>
        /// </summary>
        /// <param name="value">The value of the second type.</param>
        public OneOf(T1 value)
        {
            _value1 = value;
            _index = 1;

            _value0 = default(T0);
            _value2 = default(T2);
        }

        /// <summary>
        /// Initialises a new instance of <see cref="OneOf{T0, T1, T2}"/>
        /// </summary>
        /// <param name="value">The value of the third type.</param>
        public OneOf(T2 value)
        {
            _value2 = value;
            _index = 1;

            _value0 = default(T0);
            _value1 = default(T1);
        }

        /// <summary>
        /// Gets the value of the first type.
        /// </summary>
        public T0 AsValue0 => _value0;

        /// <summary>
        /// Gets the value of the second type.
        /// </summary>
        public T1 AsValue1 => _value1;

        /// <summary>
        /// Gets the value of the third type.
        /// </summary>
        public T2 AsValue2 => _value2;

        /// <summary>
        /// Gets whether the union value is of the first type.
        /// </summary>
        public bool IsT0 => (_index == 0);

        /// <summary>
        /// Gets whether the union value is of the second type.
        /// </summary>
        public bool IsT1 => (_index == 1);

        /// <summary>
        /// Gets whether the union value is of the third type.
        /// </summary>
        public bool IsT2 => (_index == 2);

        /// <summary>
        /// Provides an implicit conversion from a <see cref="T0"/> to a <see cref="OneOf{T0, T1, T2}"/>
        /// </summary>
        /// <param name="value">The value of the first type.</param>
        public static implicit operator OneOf<T0, T1, T2>(T0 value)
            => new OneOf<T0, T1, T2>(value);

        /// <summary>
        /// Provides an implicit conversion from a <see cref="T1"/> to a <see cref="OneOf{T0, T1, T2}"/>
        /// </summary>
        /// <param name="value">The value of the second type.</param>
        public static implicit operator OneOf<T0, T1, T2>(T1 value)
            => new OneOf<T0, T1, T2>(value);

        /// <summary>
        /// Provides an implicit conversion from a <see cref="T2"/> to a <see cref="OneOf{T0, T1, T2}"/>
        /// </summary>
        /// <param name="value">The value of the third type.</param>
        public static implicit operator OneOf<T0, T1, T2>(T2 value)
            => new OneOf<T0, T1, T2>(value);

        /// <inheritdoc />
        object IOneOf.Value => 
            IsT0 ? (object)_value0 :
            IsT1 ? (object)_value1 : _value2;
    }
}
