// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.Kernel;
using Xbim.Ifc4x3.MeasureResource;
using Xbim.Ifc4x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ArchitectureDomain;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ArchitectureDomain
{
	[ExpressType("IfcWindowLiningProperties", 252)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowLiningProperties : IfcPreDefinedPropertySet, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcWindowLiningProperties>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowLiningProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcNonNegativeLengthMeasure? _liningThickness;
		private IfcNonNegativeLengthMeasure? _transomThickness;
		private IfcNonNegativeLengthMeasure? _mullionThickness;
		private IfcNormalisedRatioMeasure? _firstTransomOffset;
		private IfcNormalisedRatioMeasure? _secondTransomOffset;
		private IfcNormalisedRatioMeasure? _firstMullionOffset;
		private IfcNormalisedRatioMeasure? _secondMullionOffset;
		private IfcShapeAspect _shapeAspectStyle;
		private IfcLengthMeasure? _liningOffset;
		private IfcLengthMeasure? _liningToPanelOffsetX;
		private IfcLengthMeasure? _liningToPanelOffsetY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcPositiveLengthMeasure? @LiningDepth 
		{ 
			get 
			{
				if(_activated) return _liningDepth;
				Activate();
				return _liningDepth;
			} 
			set
			{
				SetValue( v =>  _liningDepth = v, _liningDepth, value,  "LiningDepth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcNonNegativeLengthMeasure? @LiningThickness 
		{ 
			get 
			{
				if(_activated) return _liningThickness;
				Activate();
				return _liningThickness;
			} 
			set
			{
				SetValue( v =>  _liningThickness = v, _liningThickness, value,  "LiningThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcNonNegativeLengthMeasure? @TransomThickness 
		{ 
			get 
			{
				if(_activated) return _transomThickness;
				Activate();
				return _transomThickness;
			} 
			set
			{
				SetValue( v =>  _transomThickness = v, _transomThickness, value,  "TransomThickness", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public IfcNonNegativeLengthMeasure? @MullionThickness 
		{ 
			get 
			{
				if(_activated) return _mullionThickness;
				Activate();
				return _mullionThickness;
			} 
			set
			{
				SetValue( v =>  _mullionThickness = v, _mullionThickness, value,  "MullionThickness", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcNormalisedRatioMeasure? @FirstTransomOffset 
		{ 
			get 
			{
				if(_activated) return _firstTransomOffset;
				Activate();
				return _firstTransomOffset;
			} 
			set
			{
				SetValue( v =>  _firstTransomOffset = v, _firstTransomOffset, value,  "FirstTransomOffset", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 15)]
		public IfcNormalisedRatioMeasure? @SecondTransomOffset 
		{ 
			get 
			{
				if(_activated) return _secondTransomOffset;
				Activate();
				return _secondTransomOffset;
			} 
			set
			{
				SetValue( v =>  _secondTransomOffset = v, _secondTransomOffset, value,  "SecondTransomOffset", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 16)]
		public IfcNormalisedRatioMeasure? @FirstMullionOffset 
		{ 
			get 
			{
				if(_activated) return _firstMullionOffset;
				Activate();
				return _firstMullionOffset;
			} 
			set
			{
				SetValue( v =>  _firstMullionOffset = v, _firstMullionOffset, value,  "FirstMullionOffset", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 17)]
		public IfcNormalisedRatioMeasure? @SecondMullionOffset 
		{ 
			get 
			{
				if(_activated) return _secondMullionOffset;
				Activate();
				return _secondMullionOffset;
			} 
			set
			{
				SetValue( v =>  _secondMullionOffset = v, _secondMullionOffset, value,  "SecondMullionOffset", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 18)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(_activated) return _shapeAspectStyle;
				Activate();
				return _shapeAspectStyle;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 19)]
		public IfcLengthMeasure? @LiningOffset 
		{ 
			get 
			{
				if(_activated) return _liningOffset;
				Activate();
				return _liningOffset;
			} 
			set
			{
				SetValue( v =>  _liningOffset = v, _liningOffset, value,  "LiningOffset", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 20)]
		public IfcLengthMeasure? @LiningToPanelOffsetX 
		{ 
			get 
			{
				if(_activated) return _liningToPanelOffsetX;
				Activate();
				return _liningToPanelOffsetX;
			} 
			set
			{
				SetValue( v =>  _liningToPanelOffsetX = v, _liningToPanelOffsetX, value,  "LiningToPanelOffsetX", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 21)]
		public IfcLengthMeasure? @LiningToPanelOffsetY 
		{ 
			get 
			{
				if(_activated) return _liningToPanelOffsetY;
				Activate();
				return _liningToPanelOffsetY;
			} 
			set
			{
				SetValue( v =>  _liningToPanelOffsetY = v, _liningToPanelOffsetY, value,  "LiningToPanelOffsetY", 16);
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
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_liningDepth = value.RealVal;
					return;
				case 5: 
					_liningThickness = value.RealVal;
					return;
				case 6: 
					_transomThickness = value.RealVal;
					return;
				case 7: 
					_mullionThickness = value.RealVal;
					return;
				case 8: 
					_firstTransomOffset = value.RealVal;
					return;
				case 9: 
					_secondTransomOffset = value.RealVal;
					return;
				case 10: 
					_firstMullionOffset = value.RealVal;
					return;
				case 11: 
					_secondMullionOffset = value.RealVal;
					return;
				case 12: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				case 13: 
					_liningOffset = value.RealVal;
					return;
				case 14: 
					_liningToPanelOffsetX = value.RealVal;
					return;
				case 15: 
					_liningToPanelOffsetY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindowLiningProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ShapeAspectStyle != null)
					yield return @ShapeAspectStyle;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}