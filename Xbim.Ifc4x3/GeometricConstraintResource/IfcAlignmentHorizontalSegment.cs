// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricConstraintResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	[ExpressType("IfcAlignmentHorizontalSegment", 1405)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAlignmentHorizontalSegment : IfcAlignmentParameterSegment, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcAlignmentHorizontalSegment>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignmentHorizontalSegment(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _startPoint;
		private IfcPlaneAngleMeasure _startDirection;
		private IfcLengthMeasure _startRadiusOfCurvature;
		private IfcLengthMeasure _endRadiusOfCurvature;
		private IfcNonNegativeLengthMeasure _segmentLength;
		private IfcPositiveLengthMeasure? _gravityCenterLineHeight;
		private IfcAlignmentHorizontalSegmentTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCartesianPoint @StartPoint 
		{ 
			get 
			{
				if(_activated) return _startPoint;
				Activate();
				return _startPoint;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _startPoint = v, _startPoint, value,  "StartPoint", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPlaneAngleMeasure @StartDirection 
		{ 
			get 
			{
				if(_activated) return _startDirection;
				Activate();
				return _startDirection;
			} 
			set
			{
				SetValue( v =>  _startDirection = v, _startDirection, value,  "StartDirection", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLengthMeasure @StartRadiusOfCurvature 
		{ 
			get 
			{
				if(_activated) return _startRadiusOfCurvature;
				Activate();
				return _startRadiusOfCurvature;
			} 
			set
			{
				SetValue( v =>  _startRadiusOfCurvature = v, _startRadiusOfCurvature, value,  "StartRadiusOfCurvature", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLengthMeasure @EndRadiusOfCurvature 
		{ 
			get 
			{
				if(_activated) return _endRadiusOfCurvature;
				Activate();
				return _endRadiusOfCurvature;
			} 
			set
			{
				SetValue( v =>  _endRadiusOfCurvature = v, _endRadiusOfCurvature, value,  "EndRadiusOfCurvature", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcNonNegativeLengthMeasure @SegmentLength 
		{ 
			get 
			{
				if(_activated) return _segmentLength;
				Activate();
				return _segmentLength;
			} 
			set
			{
				SetValue( v =>  _segmentLength = v, _segmentLength, value,  "SegmentLength", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure? @GravityCenterLineHeight 
		{ 
			get 
			{
				if(_activated) return _gravityCenterLineHeight;
				Activate();
				return _gravityCenterLineHeight;
			} 
			set
			{
				SetValue( v =>  _gravityCenterLineHeight = v, _gravityCenterLineHeight, value,  "GravityCenterLineHeight", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 9)]
		public IfcAlignmentHorizontalSegmentTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 9);
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
					_startPoint = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 3: 
					_startDirection = value.RealVal;
					return;
				case 4: 
					_startRadiusOfCurvature = value.RealVal;
					return;
				case 5: 
					_endRadiusOfCurvature = value.RealVal;
					return;
				case 6: 
					_segmentLength = value.RealVal;
					return;
				case 7: 
					_gravityCenterLineHeight = value.RealVal;
					return;
				case 8: 
                    _predefinedType = (IfcAlignmentHorizontalSegmentTypeEnum) System.Enum.Parse(typeof (IfcAlignmentHorizontalSegmentTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignmentHorizontalSegment other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@StartPoint != null)
					yield return @StartPoint;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}