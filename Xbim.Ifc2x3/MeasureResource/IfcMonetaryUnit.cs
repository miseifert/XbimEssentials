// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.MeasureResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.MeasureResource
{
	[ExpressType("IfcMonetaryUnit", 545)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMonetaryUnit : PersistEntity, IInstantiableEntity, IfcUnit, IEquatable<@IfcMonetaryUnit>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMonetaryUnit(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurrencyEnum _currency;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 1)]
		public IfcCurrencyEnum @Currency 
		{ 
			get 
			{
				if(_activated) return _currency;
				Activate();
				return _currency;
			} 
			set
			{
				SetValue( v =>  _currency = v, _currency, value,  "Currency", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _currency = (IfcCurrencyEnum) System.Enum.Parse(typeof (IfcCurrencyEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMonetaryUnit other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}