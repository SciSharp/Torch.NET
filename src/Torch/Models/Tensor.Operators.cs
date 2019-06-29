using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public partial class Tensor
    {
        //------------------------------
        // Comparison operators:
        //------------------------------

        // Return self<value.
        public static Tensor<bool> operator <(Tensor a, ValueType obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__lt__", obj.ToPython()));
        }

        // Return self<=value.
        public static Tensor<bool> operator <=(Tensor a, ValueType obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__le__", obj.ToPython()));
        }

        // Return self>value.
        public static Tensor<bool> operator >(Tensor a, ValueType obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__gt__", obj.ToPython()));
        }

        // Return self>=value.
        public static Tensor<bool> operator >=(Tensor a, ValueType obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__ge__", obj.ToPython()));
        }

        /// <summary>
        /// Returns an array of bool where the elements of the array are == value
        /// </summary>
        public Tensor<bool> equals(ValueType obj)
        {
            return new Tensor<bool>(self.InvokeMethod("__eq__", obj.ToPython()));
        }

        /// <summary>
        /// Returns an array of bool where the elements of the array are != value
        /// </summary>
        public Tensor<bool> not_equals(ValueType obj)
        {
            return new Tensor<bool>(self.InvokeMethod("__ne__", obj.ToPython()));
        }

        // Return element-wise self<array.
        public static Tensor<bool> operator <(Tensor a, Tensor obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__lt__", obj.self));
        }

        // Return element-wise self<=array.
        public static Tensor<bool> operator <=(Tensor a, Tensor obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__le__", obj.self));
        }

        // Return element-wise self>array.
        public static Tensor<bool> operator >(Tensor a, Tensor obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__gt__", obj.self));
        }

        // Return element-wise self>=array.
        public static Tensor<bool> operator >=(Tensor a, Tensor obj)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__ge__", obj.self));
        }

        /// <summary>
        /// Returns an array of bool where the elements of the array are == array element-wise
        /// </summary>
        public Tensor<bool> equals(Tensor obj)
        {
            return new Tensor<bool>(self.InvokeMethod("__eq__", obj.self));
        }

        /// <summary>
        /// Returns an array of bool where the elements of the array are != array element-wise
        /// </summary>
        public Tensor<bool> not_equals(Tensor obj)
        {
            return new Tensor<bool>(self.InvokeMethod("__ne__", obj.self));
        }

        //------------------------------
        // Truth value of an array(bool) :
        //------------------------------

        /// <summary>
        /// Note
        /// Truth-value testing of an array invokes ndarray.__nonzero__, which raises an error if the
        /// number of elements in the array is larger than 1, because the truth value of such arrays is
        /// ambiguous.Use.any() and.all() instead to be clear about what is meant in such cases.
        /// (If the number of elements is 0, the array evaluates to False.)
        /// </summary>
        public static Tensor<bool> nonzero(Tensor a)
        {
            return new Tensor<bool>(a.self.InvokeMethod("__nonzero__"));
        }

        //------------------------------
        // Unary operations:
        //------------------------------

        // Return 	-self
        public static Tensor operator -(Tensor a)
        {
            return new Tensor(a.self.InvokeMethod("__neg__"));
        }

        // Return 	+self
        public static Tensor operator +(Tensor a)
        {
            return new Tensor(a.self.InvokeMethod("__pos__"));
        }

        // ndarray.__abs__(self)  // C# doesn't have an operator for that

        // Return 	~self
        public static Tensor operator ~(Tensor a)
        {
            return new Tensor(a.self.InvokeMethod("__invert__"));
        }

        //------------------------------
        // Arithmetic operators:
        //------------------------------

        // Return self+value.
        public static Tensor operator +(Tensor a, ValueType obj)
        {
            return new Tensor(a.self.InvokeMethod("__add__", obj.ToPython()));
        }

        // Return value+self.
        public static Tensor operator +(ValueType obj, Tensor a)
        {
            return new Tensor(a.self.InvokeMethod("__add__", obj.ToPython()));
        }

        // Return self-value.
        public static Tensor operator -(Tensor a, ValueType obj)
        {
            return new Tensor(a.self.InvokeMethod("__sub__", obj.ToPython()));
        }

        // Return self*value.
        public static Tensor operator *(Tensor a, ValueType obj)
        {
            return new Tensor(a.self.InvokeMethod("__mul__", obj.ToPython()));
        }

        // Return value*self.
        public static Tensor operator *(ValueType obj, Tensor a)
        {
            return new Tensor(a.self.InvokeMethod("__mul__", obj.ToPython()));
        }

        // Return self/value.
        public static Tensor operator /(Tensor a, ValueType obj)
        {
            return new Tensor(a.self.InvokeMethod("__truediv__", obj.ToPython()));
        }

        // Return element-wise self+array.
        public static Tensor operator +(Tensor a, Tensor obj)
        {
            return new Tensor(a.self.InvokeMethod("__add__", obj.self));
        }

        // Return element-wise self-array.
        public static Tensor operator -(Tensor a, Tensor obj)
        {
            return new Tensor(a.self.InvokeMethod("__sub__", obj.self));
        }

        // Return element-wise self*array.
        public static Tensor operator *(Tensor a, Tensor obj)
        {
            return new Tensor(a.self.InvokeMethod("__mul__", obj.self));
        }

        // Return element-wise self/array.
        public static Tensor operator /(Tensor a, Tensor obj)
        {
            return new Tensor(a.self.InvokeMethod("__truediv__", obj.self));
        }

        ///// <summary>
        ///// Return self/value.
        ///// </summary>
        //public static Tensor truediv(Tensor a, ValueType obj)
        //{
        //    return new Tensor(a.self.InvokeMethod("__truediv__", obj.ToPython()));
        //}

        /// <summary>
        /// Return self//value. 
        /// </summary>
        public Tensor floordiv(Tensor a, ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__floordiv__", obj.ToPython()));
        }

        // Return self%value.
        public static Tensor operator %(Tensor a, ValueType obj)
        {
            return new Tensor(a.self.InvokeMethod("__mod__", obj.ToPython()));
        }

        /// <summary>
        /// Return divmod(value). 
        /// </summary>
        public Tensor divmod(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__divmod__", obj.ToPython()));
        }

        /// <summary>
        /// Return pow(value). 
        /// </summary>
        public Tensor pow(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__pow__", obj.ToPython()));
        }

        /// <summary>
        /// Return self&lt;&lt;value.
        /// </summary>
        public static Tensor operator <<(Tensor a, int obj)
        {
            return new Tensor(a.self.InvokeMethod("__lshift__", obj.ToPython()));
        }

        /// <summary>
        /// Return self&gt;&gt;value.
        /// </summary>
        public static Tensor operator >>(Tensor a, int obj)
        {
            return new Tensor(a.self.InvokeMethod("__rshift__", obj.ToPython()));
        }

        /// <summary>
        /// Return self&value.
        /// </summary>
        public static Tensor operator &(Tensor a, int obj)
        {
            return new Tensor(a.self.InvokeMethod("__and__", obj.ToPython()));
        }

        /// <summary>
        /// Return self|value.
        /// </summary>
        public static Tensor operator |(Tensor a, int obj)
        {
            return new Tensor(a.self.InvokeMethod("__or__", obj.ToPython()));
        }

        /// <summary>
        /// Return self^value.
        /// </summary>
        public static Tensor operator ^(Tensor a, int obj)
        {
            return new Tensor(a.self.InvokeMethod("__xor__", obj.ToPython()));
        }

        //------------------------------
        // Arithmetic, in-place:
        //------------------------------

        /// <summary>
        /// Return self+=value.
        /// </summary>
        public Tensor iadd(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__iadd__", obj.ToPython()));
        }

        /// <summary>
        /// Return self-=value.
        /// </summary>
        public Tensor isub(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__isub__", obj.ToPython()));
        }

        /// <summary>
        /// Return self*=value.
        /// </summary>
        public Tensor imul(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__imul__", obj.ToPython()));
        }

        /// <summary>
        /// Return self/=value.
        /// </summary>
        public Tensor idiv(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__itruediv__", obj.ToPython()));
        }

        /// <summary>
        /// Return self/=value.
        /// </summary>
        public Tensor itruediv(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__itruediv__", obj.ToPython()));
        }

        /// <summary>
        /// Return self//=value. 
        /// </summary>
        public Tensor ifloordiv(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__floordiv__", obj.ToPython()));
        }

        /// <summary>
        /// Return self%value.
        /// </summary>
        public Tensor imod(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__imod__", obj.ToPython()));
        }

        /// <summary>
        /// Return inplace pow(value). 
        /// </summary>
        public Tensor ipow(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__ipow__", obj.ToPython()));
        }

        /// <summary>
        /// Return inplace self&lt;&lt;value.
        /// </summary>
        public Tensor ilshift(int obj)
        {
            return new Tensor(self.InvokeMethod("__ilshift__", obj.ToPython()));
        }

        /// <summary>
        /// Return inplace self&gt;&gt;value.
        /// </summary>
        public Tensor irshift(int obj)
        {
            return new Tensor(self.InvokeMethod("__irshift__", obj.ToPython()));
        }

        /// <summary>
        /// Return self&=value.
        /// </summary>
        public Tensor iand(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__iand__", obj.ToPython()));
        }

        /// <summary>
        /// Return self|=value.
        /// </summary>
        public Tensor ior(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__ior__", obj.ToPython()));
        }

        /// <summary>
        /// Return self^=value.
        /// </summary>
        public Tensor ixor(ValueType obj)
        {
            return new Tensor(self.InvokeMethod("__ixor__", obj.ToPython()));
        }

        /// <summary>
        /// Return self+=Tensor.
        /// </summary>
        public Tensor iadd(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__iadd__", obj.self));
        }

        /// <summary>
        /// Return self-=Tensor.
        /// </summary>
        public Tensor isub(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__isub__", obj.self));
        }

        /// <summary>
        /// Return self*=Tensor.
        /// </summary>
        public Tensor imul(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__imul__", obj.self));
        }

        /// <summary>
        /// Return self/=Tensor.
        /// </summary>
        public Tensor idiv(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__idiv__", obj.self));
        }

        /// <summary>
        /// Return self/=Tensor.
        /// </summary>
        public Tensor itruediv(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__itruediv__", obj.self));
        }

        /// <summary>
        /// Return self//=Tensor. 
        /// </summary>
        public Tensor ifloordiv(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__floordiv__", obj.self));
        }

        /// <summary>
        /// Return self%Tensor.
        /// </summary>
        public Tensor imod(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__imod__", obj.self));
        }

        /// <summary>
        /// Return inplace pow(Tensor). 
        /// </summary>
        public Tensor ipow(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__ipow__", obj.self));
        }

        /// <summary>
        /// Return inplace self&lt;&lt;Tensor.
        /// </summary>
        public Tensor ilshift(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__ilshift__", obj.self));
        }

        /// <summary>
        /// Return inplace self&gt;&gt;Tensor.
        /// </summary>
        public Tensor irshift(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__irshift__", obj.self));
        }

        /// <summary>
        /// Return self&=Tensor.
        /// </summary>
        public Tensor iand(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__iand__", obj.self));
        }

        /// <summary>
        /// Return self|=Tensor.
        /// </summary>
        public Tensor ior(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__ior__", obj.self));
        }

        /// <summary>
        /// Return self^=Tensor.
        /// </summary>
        public Tensor ixor(Tensor obj)
        {
            return new Tensor(self.InvokeMethod("__ixor__", obj.self));
        }

    }
}
