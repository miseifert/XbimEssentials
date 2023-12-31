// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.PresentationDefinitionResource;
using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	[ExpressType("IfcCurveStyleFontAndScaling", 569)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFontAndScaling : IfcPresentationItem, IInstantiableEntity, IfcCurveFontOrScaledCurveFontSelect, IContainsEntityReferences, IEquatable<@IfcCurveStyleFontAndScaling>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFontAndScaling(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcCurveStyleFontSelect _curveStyleFont;
		private IfcPositiveRatioMeasure _curveFontScaling;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcCurveStyleFontSelect @CurveStyleFont 
		{ 
			get 
			{
				if(_activated) return _curveStyleFont;
				Activate();
				return _curveStyleFont;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _curveStyleFont = v, _curveStyleFont, value,  "CurveStyleFont", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcPositiveRatioMeasure @CurveFontScaling 
		{ 
			get 
			{
				if(_activated) return _curveFontScaling;
				Activate();
				return _curveFontScaling;
			} 
			set
			{
				SetValue( v =>  _curveFontScaling = v, _curveFontScaling, value,  "CurveFontScaling", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_curveStyleFont = (IfcCurveStyleFontSelect)(value.EntityVal);
					return;
				case 2: 
					_curveFontScaling = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyleFontAndScaling other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@CurveStyleFont != null)
					yield return @CurveStyleFont;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}