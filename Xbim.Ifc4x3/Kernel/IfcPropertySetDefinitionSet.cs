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
using Xbim.Ifc4x3.Kernel;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4x3.Kernel
{
	[ExpressType("IfcPropertySetDefinitionSet", 996)]
	[DefinedType(typeof(List<IfcPropertySetDefinition>))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcPropertySetDefinitionSet : IfcPropertySetDefinitionSelect, IExpressComplexType, System.IEquatable<List<IfcPropertySetDefinition>>
	{ 
		private List<IfcPropertySetDefinition> _value;
        
		public static void Add(ref IfcPropertySetDefinitionSet comp, IfcPropertySetDefinition component)
        {
            if (comp._value == null)
                comp.Initialise(component);
            else
                comp._value.Add(component);
        }

		private void Initialise(IfcPropertySetDefinition comp)
        {
            _value = new List<IfcPropertySetDefinition>{ comp };
        }

		public object Value
        {
            get { return _value; }
        }

        public IfcPropertySetDefinitionSet(List<IfcPropertySetDefinition> val)
        {
			//copy items into new inner list
			_value = new List<IfcPropertySetDefinition>(val);
        }


        public static implicit operator IfcPropertySetDefinitionSet(List<IfcPropertySetDefinition> value)
        {
            return new IfcPropertySetDefinitionSet(value);
        }

        public static implicit operator List<IfcPropertySetDefinition>(IfcPropertySetDefinitionSet obj)
        {
			//return copy so that underlying collection is not exposed
			return new List<IfcPropertySetDefinition>(obj._value);

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return System.Linq.Enumerable.SequenceEqual(((IfcPropertySetDefinitionSet) obj)._value, _value);
        }

		public bool Equals(List<IfcPropertySetDefinition> other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcPropertySetDefinitionSet obj1, IfcPropertySetDefinitionSet obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcPropertySetDefinitionSet obj1, IfcPropertySetDefinitionSet obj2)
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
				_value = new List<IfcPropertySetDefinition>();
            _value.Add(value.EntityVal as IfcPropertySetDefinition);
            
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(List<IfcPropertySetDefinition>);
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
