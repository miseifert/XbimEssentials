// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterial
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterial : IIfcMaterialDefinition
	{
		IfcLabel @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IfcLabel? @Category { get;  set; }
		IEnumerable<IIfcMaterialDefinitionRepresentation> @HasRepresentation {  get; }
		IEnumerable<IIfcMaterialRelationship> @IsRelatedWith {  get; }
		IEnumerable<IIfcMaterialRelationship> @RelatesTo {  get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterial", 94)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterial : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterial, IEquatable<@IfcMaterial>
	{
		#region IIfcMaterial explicit implementation
		IfcLabel IIfcMaterial.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcMaterial.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcLabel? IIfcMaterial.Category { 
 
			get { return @Category; } 
			set { Category = value;}
		}	
		IEnumerable<IIfcMaterialDefinitionRepresentation> IIfcMaterial.HasRepresentation {  get { return @HasRepresentation; } }
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.IsRelatedWith {  get { return @IsRelatedWith; } }
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.RelatesTo {  get { return @RelatesTo; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterial(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcLabel? _category;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLabel @Name 
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(_activated) return _category;
				Activate();
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category", 3);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RepresentedMaterial")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 7)]
		public IEnumerable<IfcMaterialDefinitionRepresentation> @HasRepresentation 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialDefinitionRepresentation>(e => Equals(e.RepresentedMaterial), "RepresentedMaterial", this);
			} 
		}
		[InverseProperty("RelatedMaterials")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 8)]
		public IEnumerable<IfcMaterialRelationship> @IsRelatedWith 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialRelationship>(e => e.RelatedMaterials != null &&  e.RelatedMaterials.Contains(this), "RelatedMaterials", this);
			} 
		}
		[InverseProperty("RelatingMaterial")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 9)]
		public IEnumerable<IfcMaterialRelationship> @RelatesTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMaterialRelationship>(e => Equals(e.RelatingMaterial), "RelatingMaterial", this);
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
					_description = value.StringVal;
					return;
				case 2: 
					_category = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterial other)
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