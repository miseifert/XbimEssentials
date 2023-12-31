// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.PresentationDefinitionResource;
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
	[ExpressType("IfcSurfaceStyleLighting", 117)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleLighting : IfcPresentationItem, IInstantiableEntity, IfcSurfaceStyleElementSelect, IContainsEntityReferences, IEquatable<@IfcSurfaceStyleLighting>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleLighting(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcColourRgb _diffuseTransmissionColour;
		private IfcColourRgb _diffuseReflectionColour;
		private IfcColourRgb _transmissionColour;
		private IfcColourRgb _reflectanceColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcColourRgb @DiffuseTransmissionColour 
		{ 
			get 
			{
				if(_activated) return _diffuseTransmissionColour;
				Activate();
				return _diffuseTransmissionColour;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _diffuseTransmissionColour = v, _diffuseTransmissionColour, value,  "DiffuseTransmissionColour", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcColourRgb @DiffuseReflectionColour 
		{ 
			get 
			{
				if(_activated) return _diffuseReflectionColour;
				Activate();
				return _diffuseReflectionColour;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _diffuseReflectionColour = v, _diffuseReflectionColour, value,  "DiffuseReflectionColour", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcColourRgb @TransmissionColour 
		{ 
			get 
			{
				if(_activated) return _transmissionColour;
				Activate();
				return _transmissionColour;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _transmissionColour = v, _transmissionColour, value,  "TransmissionColour", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcColourRgb @ReflectanceColour 
		{ 
			get 
			{
				if(_activated) return _reflectanceColour;
				Activate();
				return _reflectanceColour;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _reflectanceColour = v, _reflectanceColour, value,  "ReflectanceColour", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_diffuseTransmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 1: 
					_diffuseReflectionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 2: 
					_transmissionColour = (IfcColourRgb)(value.EntityVal);
					return;
				case 3: 
					_reflectanceColour = (IfcColourRgb)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyleLighting other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@DiffuseTransmissionColour != null)
					yield return @DiffuseTransmissionColour;
				if (@DiffuseReflectionColour != null)
					yield return @DiffuseReflectionColour;
				if (@TransmissionColour != null)
					yield return @TransmissionColour;
				if (@ReflectanceColour != null)
					yield return @ReflectanceColour;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}