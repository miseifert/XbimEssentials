// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAlignment2DVertical
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAlignment2DVertical : IIfcGeometricRepresentationItem
	{
		IItemSet<IIfcAlignment2DVerticalSegment> @Segments { get; }
		IEnumerable<IIfcAlignmentCurve> @ToAlignmentCurve {  get; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcAlignment2DVertical", 1338)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAlignment2DVertical : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcAlignment2DVertical, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcAlignment2DVertical>
	{
		#region IIfcAlignment2DVertical explicit implementation
		IItemSet<IIfcAlignment2DVerticalSegment> IIfcAlignment2DVertical.Segments { 
			get { return new Common.Collections.ProxyItemSet<IfcAlignment2DVerticalSegment, IIfcAlignment2DVerticalSegment>( @Segments); } 
		}	
		IEnumerable<IIfcAlignmentCurve> IIfcAlignment2DVertical.ToAlignmentCurve {  get { return @ToAlignmentCurve; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAlignment2DVertical(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_segments = new ItemSet<IfcAlignment2DVerticalSegment>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcAlignment2DVerticalSegment> _segments;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcAlignment2DVerticalSegment> @Segments 
		{ 
			get 
			{
				if(_activated) return _segments;
				Activate();
				return _segments;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Vertical")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { 1 }, 4)]
		public IEnumerable<IfcAlignmentCurve> @ToAlignmentCurve 
		{ 
			get 
			{
				return Model.Instances.Where<IfcAlignmentCurve>(e => Equals(e.Vertical), "Vertical", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_segments.InternalAdd((IfcAlignment2DVerticalSegment)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAlignment2DVertical other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Segments)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Segments)
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