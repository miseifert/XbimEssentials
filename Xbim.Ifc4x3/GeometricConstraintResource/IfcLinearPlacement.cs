// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.GeometryResource;
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
	[ExpressType("IfcLinearPlacement", 1349)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLinearPlacement : IfcObjectPlacement, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcLinearPlacement>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLinearPlacement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAxis2PlacementLinear _relativePlacement;
		private IfcAxis2Placement3D _cartesianPosition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcAxis2PlacementLinear @RelativePlacement 
		{ 
			get 
			{
				if(_activated) return _relativePlacement;
				Activate();
				return _relativePlacement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relativePlacement = v, _relativePlacement, value,  "RelativePlacement", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcAxis2Placement3D @CartesianPosition 
		{ 
			get 
			{
				if(_activated) return _cartesianPosition;
				Activate();
				return _cartesianPosition;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _cartesianPosition = v, _cartesianPosition, value,  "CartesianPosition", 3);
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
					_relativePlacement = (IfcAxis2PlacementLinear)(value.EntityVal);
					return;
				case 2: 
					_cartesianPosition = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLinearPlacement other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PlacementRelTo != null)
					yield return @PlacementRelTo;
				if (@RelativePlacement != null)
					yield return @RelativePlacement;
				if (@CartesianPosition != null)
					yield return @CartesianPosition;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@PlacementRelTo != null)
					yield return @PlacementRelTo;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}