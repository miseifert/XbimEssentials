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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMappedItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMappedItem : IIfcRepresentationItem
	{
		IIfcRepresentationMap @MappingSource { get;  set; }
		IIfcCartesianTransformationOperator @MappingTarget { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcMappedItem", 333)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMappedItem : IfcRepresentationItem, IInstantiableEntity, IIfcMappedItem, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMappedItem>
	{
		#region IIfcMappedItem explicit implementation
		IIfcRepresentationMap IIfcMappedItem.MappingSource { 
 
 
			get { return @MappingSource; } 
			set { MappingSource = value as IfcRepresentationMap;}
		}	
		IIfcCartesianTransformationOperator IIfcMappedItem.MappingTarget { 
 
 
			get { return @MappingTarget; } 
			set { MappingTarget = value as IfcCartesianTransformationOperator;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMappedItem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcRepresentationMap _mappingSource;
		private IfcCartesianTransformationOperator _mappingTarget;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcRepresentationMap @MappingSource 
		{ 
			get 
			{
				if(_activated) return _mappingSource;
				Activate();
				return _mappingSource;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _mappingSource = v, _mappingSource, value,  "MappingSource", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCartesianTransformationOperator @MappingTarget 
		{ 
			get 
			{
				if(_activated) return _mappingTarget;
				Activate();
				return _mappingTarget;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _mappingTarget = v, _mappingTarget, value,  "MappingTarget", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_mappingSource = (IfcRepresentationMap)(value.EntityVal);
					return;
				case 1: 
					_mappingTarget = (IfcCartesianTransformationOperator)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMappedItem other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@MappingSource != null)
					yield return @MappingSource;
				if (@MappingTarget != null)
					yield return @MappingTarget;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@MappingSource != null)
					yield return @MappingSource;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}