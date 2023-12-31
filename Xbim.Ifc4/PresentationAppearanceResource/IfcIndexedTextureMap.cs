// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometricModelResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcIndexedTextureMap
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcIndexedTextureMap : IIfcTextureCoordinate
	{
		IIfcTessellatedFaceSet @MappedTo { get;  set; }
		IIfcTextureVertexList @TexCoords { get;  set; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcIndexedTextureMap", 1191)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcIndexedTextureMap : IfcTextureCoordinate, IIfcIndexedTextureMap, IEquatable<@IfcIndexedTextureMap>
	{
		#region IIfcIndexedTextureMap explicit implementation
		IIfcTessellatedFaceSet IIfcIndexedTextureMap.MappedTo { 
 
 
			get { return @MappedTo; } 
			set { MappedTo = value as IfcTessellatedFaceSet;}
		}	
		IIfcTextureVertexList IIfcIndexedTextureMap.TexCoords { 
 
 
			get { return @TexCoords; } 
			set { TexCoords = value as IfcTextureVertexList;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedTextureMap(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTessellatedFaceSet _mappedTo;
		private IfcTextureVertexList _texCoords;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcTessellatedFaceSet @MappedTo 
		{ 
			get 
			{
				if(_activated) return _mappedTo;
				Activate();
				return _mappedTo;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _mappedTo = v, _mappedTo, value,  "MappedTo", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcTextureVertexList @TexCoords 
		{ 
			get 
			{
				if(_activated) return _texCoords;
				Activate();
				return _texCoords;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _texCoords = v, _texCoords, value,  "TexCoords", 3);
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
					_mappedTo = (IfcTessellatedFaceSet)(value.EntityVal);
					return;
				case 2: 
					_texCoords = (IfcTextureVertexList)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIndexedTextureMap other)
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