// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.MaterialResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.MaterialResource
{
	[ExpressType("IfcMaterialConstituentSet", 1202)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialConstituentSet : IfcMaterialDefinition, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMaterialConstituentSet>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialConstituentSet(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_materialConstituents = new OptionalItemSet<IfcMaterialConstituent>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private readonly OptionalItemSet<IfcMaterialConstituent> _materialConstituents;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLabel? @Name 
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
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IOptionalItemSet<IfcMaterialConstituent> @MaterialConstituents 
		{ 
			get 
			{
				if(_activated) return _materialConstituents;
				Activate();
				return _materialConstituents;
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
					_materialConstituents.InternalAdd((IfcMaterialConstituent)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialConstituentSet other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @MaterialConstituents)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @MaterialConstituents)
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