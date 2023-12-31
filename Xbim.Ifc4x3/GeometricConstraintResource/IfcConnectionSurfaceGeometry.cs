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
using Xbim.Ifc4x3.GeometricConstraintResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricConstraintResource
{
	[ExpressType("IfcConnectionSurfaceGeometry", 69)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionSurfaceGeometry : IfcConnectionGeometry, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcConnectionSurfaceGeometry>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionSurfaceGeometry(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSurfaceOrFaceSurface _surfaceOnRelatingElement;
		private IfcSurfaceOrFaceSurface _surfaceOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatingElement 
		{ 
			get 
			{
				if(_activated) return _surfaceOnRelatingElement;
				Activate();
				return _surfaceOnRelatingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _surfaceOnRelatingElement = v, _surfaceOnRelatingElement, value,  "SurfaceOnRelatingElement", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcSurfaceOrFaceSurface @SurfaceOnRelatedElement 
		{ 
			get 
			{
				if(_activated) return _surfaceOnRelatedElement;
				Activate();
				return _surfaceOnRelatedElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _surfaceOnRelatedElement = v, _surfaceOnRelatedElement, value,  "SurfaceOnRelatedElement", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_surfaceOnRelatingElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
					return;
				case 1: 
					_surfaceOnRelatedElement = (IfcSurfaceOrFaceSurface)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConnectionSurfaceGeometry other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SurfaceOnRelatingElement != null)
					yield return @SurfaceOnRelatingElement;
				if (@SurfaceOnRelatedElement != null)
					yield return @SurfaceOnRelatedElement;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}