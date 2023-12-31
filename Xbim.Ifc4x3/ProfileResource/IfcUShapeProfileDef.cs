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
using Xbim.Ifc4x3.ProfileResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProfileResource
{
	[ExpressType("IfcUShapeProfileDef", 670)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcUShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcUShapeProfileDef>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcUShapeProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _depth;
		private IfcPositiveLengthMeasure _flangeWidth;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _flangeThickness;
		private IfcNonNegativeLengthMeasure? _filletRadius;
		private IfcNonNegativeLengthMeasure? _edgeRadius;
		private IfcPlaneAngleMeasure? _flangeSlope;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveLengthMeasure @Depth 
		{ 
			get 
			{
				if(_activated) return _depth;
				Activate();
				return _depth;
			} 
			set
			{
				SetValue( v =>  _depth = v, _depth, value,  "Depth", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPositiveLengthMeasure @FlangeWidth 
		{ 
			get 
			{
				if(_activated) return _flangeWidth;
				Activate();
				return _flangeWidth;
			} 
			set
			{
				SetValue( v =>  _flangeWidth = v, _flangeWidth, value,  "FlangeWidth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(_activated) return _webThickness;
				Activate();
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcPositiveLengthMeasure @FlangeThickness 
		{ 
			get 
			{
				if(_activated) return _flangeThickness;
				Activate();
				return _flangeThickness;
			} 
			set
			{
				SetValue( v =>  _flangeThickness = v, _flangeThickness, value,  "FlangeThickness", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcNonNegativeLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(_activated) return _filletRadius;
				Activate();
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcNonNegativeLengthMeasure? @EdgeRadius 
		{ 
			get 
			{
				if(_activated) return _edgeRadius;
				Activate();
				return _edgeRadius;
			} 
			set
			{
				SetValue( v =>  _edgeRadius = v, _edgeRadius, value,  "EdgeRadius", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcPlaneAngleMeasure? @FlangeSlope 
		{ 
			get 
			{
				if(_activated) return _flangeSlope;
				Activate();
				return _flangeSlope;
			} 
			set
			{
				SetValue( v =>  _flangeSlope = v, _flangeSlope, value,  "FlangeSlope", 10);
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
					_depth = value.RealVal;
					return;
				case 4: 
					_flangeWidth = value.RealVal;
					return;
				case 5: 
					_webThickness = value.RealVal;
					return;
				case 6: 
					_flangeThickness = value.RealVal;
					return;
				case 7: 
					_filletRadius = value.RealVal;
					return;
				case 8: 
					_edgeRadius = value.RealVal;
					return;
				case 9: 
					_flangeSlope = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcUShapeProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}