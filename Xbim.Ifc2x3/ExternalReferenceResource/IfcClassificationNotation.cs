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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcClassificationNotation", 13)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationNotation : PersistEntity, IInstantiableEntity, IfcClassificationNotationSelect, IContainsEntityReferences, IEquatable<@IfcClassificationNotation>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassificationNotation(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_notationFacets = new ItemSet<IfcClassificationNotationFacet>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcClassificationNotationFacet> _notationFacets;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 1)]
		public IItemSet<IfcClassificationNotationFacet> @NotationFacets 
		{ 
			get 
			{
				if(_activated) return _notationFacets;
				Activate();
				return _notationFacets;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_notationFacets.InternalAdd((IfcClassificationNotationFacet)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcClassificationNotation other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @NotationFacets)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}