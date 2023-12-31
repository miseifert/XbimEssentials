// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcProductsOfCombustionProperties", 719)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProductsOfCombustionProperties : IfcMaterialProperties, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcProductsOfCombustionProperties>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProductsOfCombustionProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSpecificHeatCapacityMeasure? _specificHeatCapacity;
		private IfcPositiveRatioMeasure? _n20Content;
		private IfcPositiveRatioMeasure? _cOContent;
		private IfcPositiveRatioMeasure? _cO2Content;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcSpecificHeatCapacityMeasure? @SpecificHeatCapacity 
		{ 
			get 
			{
				if(_activated) return _specificHeatCapacity;
				Activate();
				return _specificHeatCapacity;
			} 
			set
			{
				SetValue( v =>  _specificHeatCapacity = v, _specificHeatCapacity, value,  "SpecificHeatCapacity", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcPositiveRatioMeasure? @N20Content 
		{ 
			get 
			{
				if(_activated) return _n20Content;
				Activate();
				return _n20Content;
			} 
			set
			{
				SetValue( v =>  _n20Content = v, _n20Content, value,  "N20Content", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveRatioMeasure? @COContent 
		{ 
			get 
			{
				if(_activated) return _cOContent;
				Activate();
				return _cOContent;
			} 
			set
			{
				SetValue( v =>  _cOContent = v, _cOContent, value,  "COContent", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveRatioMeasure? @CO2Content 
		{ 
			get 
			{
				if(_activated) return _cO2Content;
				Activate();
				return _cO2Content;
			} 
			set
			{
				SetValue( v =>  _cO2Content = v, _cO2Content, value,  "CO2Content", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_specificHeatCapacity = value.RealVal;
					return;
				case 2: 
					_n20Content = value.RealVal;
					return;
				case 3: 
					_cOContent = value.RealVal;
					return;
				case 4: 
					_cO2Content = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProductsOfCombustionProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}