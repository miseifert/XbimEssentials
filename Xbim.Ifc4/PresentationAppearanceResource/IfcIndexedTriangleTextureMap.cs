// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
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
    /// Readonly interface for IfcIndexedTriangleTextureMap
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcIndexedTriangleTextureMap : IIfcIndexedTextureMap
	{
		IItemSet<IItemSet<IfcPositiveInteger>> @TexCoordIndex { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcIndexedTriangleTextureMap", 1192)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIndexedTriangleTextureMap : IfcIndexedTextureMap, IInstantiableEntity, IIfcIndexedTriangleTextureMap, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcIndexedTriangleTextureMap>
	{
		#region IIfcIndexedTriangleTextureMap explicit implementation
		IItemSet<IItemSet<IfcPositiveInteger>> IIfcIndexedTriangleTextureMap.TexCoordIndex { 
			get { return @TexCoordIndex; } 
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedTriangleTextureMap(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_texCoordIndex = new OptionalItemSet<IItemSet<IfcPositiveInteger>>( this, 0,  4);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IItemSet<IfcPositiveInteger>> _texCoordIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, new int [] { 1, 3 }, new int [] { -1, 3 }, 4)]
		public IOptionalItemSet<IItemSet<IfcPositiveInteger>> @TexCoordIndex 
		{ 
			get 
			{
				if(_activated) return _texCoordIndex;
				Activate();
				return _texCoordIndex;
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
					((ItemSet<IfcPositiveInteger>)_texCoordIndex
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcPositiveInteger)(value.IntegerVal));
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIndexedTriangleTextureMap other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Maps)
					yield return entity;
				if (@MappedTo != null)
					yield return @MappedTo;
				if (@TexCoords != null)
					yield return @TexCoords;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Maps)
					yield return entity;
				if (@MappedTo != null)
					yield return @MappedTo;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}