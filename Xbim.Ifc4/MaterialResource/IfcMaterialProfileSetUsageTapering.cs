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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialProfileSetUsageTapering
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialProfileSetUsageTapering : IIfcMaterialProfileSetUsage
	{
		IIfcMaterialProfileSet @ForProfileEndSet { get;  set; }
		IfcCardinalPointReference? @CardinalEndPoint { get;  set; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialProfileSetUsageTapering", 1208)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfileSetUsageTapering : IfcMaterialProfileSetUsage, IInstantiableEntity, IIfcMaterialProfileSetUsageTapering, IContainsEntityReferences, IEquatable<@IfcMaterialProfileSetUsageTapering>
	{
		#region IIfcMaterialProfileSetUsageTapering explicit implementation
		IIfcMaterialProfileSet IIfcMaterialProfileSetUsageTapering.ForProfileEndSet { 
 
 
			get { return @ForProfileEndSet; } 
			set { ForProfileEndSet = value as IfcMaterialProfileSet;}
		}	
		IfcCardinalPointReference? IIfcMaterialProfileSetUsageTapering.CardinalEndPoint { 
 
			get { return @CardinalEndPoint; } 
			set { CardinalEndPoint = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSetUsageTapering(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcMaterialProfileSet _forProfileEndSet;
		private IfcCardinalPointReference? _cardinalEndPoint;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcMaterialProfileSet @ForProfileEndSet 
		{ 
			get 
			{
				if(_activated) return _forProfileEndSet;
				Activate();
				return _forProfileEndSet;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _forProfileEndSet = v, _forProfileEndSet, value,  "ForProfileEndSet", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcCardinalPointReference? @CardinalEndPoint 
		{ 
			get 
			{
				if(_activated) return _cardinalEndPoint;
				Activate();
				return _cardinalEndPoint;
			} 
			set
			{
				SetValue( v =>  _cardinalEndPoint = v, _cardinalEndPoint, value,  "CardinalEndPoint", 5);
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
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_forProfileEndSet = (IfcMaterialProfileSet)(value.EntityVal);
					return;
				case 4: 
					_cardinalEndPoint = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialProfileSetUsageTapering other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ForProfileSet != null)
					yield return @ForProfileSet;
				if (@ForProfileEndSet != null)
					yield return @ForProfileEndSet;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}