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
	[ExpressType("IfcDoorPanelProperties", 602)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoorPanelProperties : IfcPreDefinedPropertySet, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcDoorPanelProperties>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorPanelProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _panelDepth;
		private IfcDoorPanelOperationEnum _panelOperation;
		private IfcNormalisedRatioMeasure? _panelWidth;
		private IfcDoorPanelPositionEnum _panelPosition;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcPositiveLengthMeasure? @PanelDepth 
		{ 
			get 
			{
				if(_activated) return _panelDepth;
				Activate();
				return _panelDepth;
			} 
			set
			{
				SetValue( v =>  _panelDepth = v, _panelDepth, value,  "PanelDepth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 11)]
		public IfcDoorPanelOperationEnum @PanelOperation 
		{ 
			get 
			{
				if(_activated) return _panelOperation;
				Activate();
				return _panelOperation;
			} 
			set
			{
				SetValue( v =>  _panelOperation = v, _panelOperation, value,  "PanelOperation", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcNormalisedRatioMeasure? @PanelWidth 
		{ 
			get 
			{
				if(_activated) return _panelWidth;
				Activate();
				return _panelWidth;
			} 
			set
			{
				SetValue( v =>  _panelWidth = v, _panelWidth, value,  "PanelWidth", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 13)]
		public IfcDoorPanelPositionEnum @PanelPosition 
		{ 
			get 
			{
				if(_activated) return _panelPosition;
				Activate();
				return _panelPosition;
			} 
			set
			{
				SetValue( v =>  _panelPosition = v, _panelPosition, value,  "PanelPosition", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 14)]
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
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle", 9);
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
					_panelDepth = value.RealVal;
					return;
				case 5: 
                    _panelOperation = (IfcDoorPanelOperationEnum) System.Enum.Parse(typeof (IfcDoorPanelOperationEnum), value.EnumVal, true);
					return;
				case 6: 
					_panelWidth = value.RealVal;
					return;
				case 7: 
                    _panelPosition = (IfcDoorPanelPositionEnum) System.Enum.Parse(typeof (IfcDoorPanelPositionEnum), value.EnumVal, true);
					return;
				case 8: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDoorPanelProperties other)
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