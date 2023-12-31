// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.PropertyResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.PropertyResource
{
	[ExpressType("IfcPropertyListValue", 489)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyListValue : IfcSimpleProperty, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcPropertyListValue>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyListValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_listValues = new OptionalItemSet<IfcValue>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcValue> _listValues;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 10)]
		public IOptionalItemSet<IfcValue> @ListValues 
		{ 
			get 
			{
				if(_activated) return _listValues;
				Activate();
				return _listValues;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 11)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(_activated) return _unit;
				Activate();
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_listValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyListValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}