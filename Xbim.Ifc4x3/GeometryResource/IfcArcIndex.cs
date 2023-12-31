// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Xbim.Ifc4x3.MeasureResource;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4x3.GeometryResource
{
	[ExpressType("IfcArcIndex", 984)]
	[DefinedType(typeof(List<IfcPositiveInteger>))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcArcIndex : IfcSegmentIndexSelect, IExpressComplexType, System.IEquatable<List<IfcPositiveInteger>>
	{ 
		private List<IfcPositiveInteger> _value;
        
		public static void Add(ref IfcArcIndex comp, IfcPositiveInteger component)
        {
            if (comp._value == null)
                comp.Initialise(component);
            else
                comp._value.Add(component);
        }

		private void Initialise(IfcPositiveInteger comp)
        {
            _value = new List<IfcPositiveInteger>{ comp };
        }

		public object Value
        {
            get { return _value; }
        }

        public IfcArcIndex(List<IfcPositiveInteger> val)
        {
			//copy items into new inner list
			_value = new List<IfcPositiveInteger>(val);
        }


        public static implicit operator IfcArcIndex(List<IfcPositiveInteger> value)
        {
            return new IfcArcIndex(value);
        }

        public static implicit operator List<IfcPositiveInteger>(IfcArcIndex obj)
        {
			//return copy so that underlying collection is not exposed
			return new List<IfcPositiveInteger>(obj._value);

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return System.Linq.Enumerable.SequenceEqual(((IfcArcIndex) obj)._value, _value);
        }

		public bool Equals(List<IfcPositiveInteger> other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcArcIndex obj1, IfcArcIndex obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcArcIndex obj1, IfcArcIndex obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.Sum(o => o.GetHashCode()) : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			if (_value == null)
				_value = new List<IfcPositiveInteger>();
            _value.Add(value.IntegerVal);
            
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(List<IfcPositiveInteger>);
			}
		}
		#endregion

		#region IExpressComplexType implementation
		IEnumerable<object> IExpressComplexType.Properties
        {
            get
            {
				if(_value == null) yield break;
	            foreach (var value in _value)
	                yield return value;
            }
        }
		#endregion

	}
}
