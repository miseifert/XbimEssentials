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
	[ExpressType("IfcPropertyReferenceValue", 277)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyReferenceValue : IfcSimpleProperty, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcPropertyReferenceValue>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyReferenceValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcText? _usageName;
		private IfcObjectReferenceSelect _propertyReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcText? @UsageName 
		{ 
			get 
			{
				if(_activated) return _usageName;
				Activate();
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 11)]
		public IfcObjectReferenceSelect @PropertyReference 
		{ 
			get 
			{
				if(_activated) return _propertyReference;
				Activate();
				return _propertyReference;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _propertyReference = v, _propertyReference, value,  "PropertyReference", 4);
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
					_usageName = value.StringVal;
					return;
				case 3: 
					_propertyReference = (IfcObjectReferenceSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyReferenceValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PropertyReference != null)
					yield return @PropertyReference;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}