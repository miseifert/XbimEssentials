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
using Xbim.Ifc4x3.Kernel;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.Kernel
{
	[ExpressType("IfcPropertySetTemplate", 1232)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertySetTemplate : IfcPropertyTemplateDefinition, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPropertySetTemplate>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertySetTemplate(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_hasPropertyTemplates = new ItemSet<IfcPropertyTemplate>( this, 0,  7);
		}

		#region Explicit attribute fields
		private IfcPropertySetTemplateTypeEnum? _templateType;
		private IfcIdentifier? _applicableEntity;
		private readonly ItemSet<IfcPropertyTemplate> _hasPropertyTemplates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 7)]
		public IfcPropertySetTemplateTypeEnum? @TemplateType 
		{ 
			get 
			{
				if(_activated) return _templateType;
				Activate();
				return _templateType;
			} 
			set
			{
				SetValue( v =>  _templateType = v, _templateType, value,  "TemplateType", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcIdentifier? @ApplicableEntity 
		{ 
			get 
			{
				if(_activated) return _applicableEntity;
				Activate();
				return _applicableEntity;
			} 
			set
			{
				SetValue( v =>  _applicableEntity = v, _applicableEntity, value,  "ApplicableEntity", 6);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 9)]
		public IItemSet<IfcPropertyTemplate> @HasPropertyTemplates 
		{ 
			get 
			{
				if(_activated) return _hasPropertyTemplates;
				Activate();
				return _hasPropertyTemplates;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingTemplate")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 10)]
		public IEnumerable<IfcRelDefinesByTemplate> @Defines 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByTemplate>(e => Equals(e.RelatingTemplate), "RelatingTemplate", this);
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
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
                    _templateType = (IfcPropertySetTemplateTypeEnum) System.Enum.Parse(typeof (IfcPropertySetTemplateTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_applicableEntity = value.StringVal;
					return;
				case 6: 
					_hasPropertyTemplates.InternalAdd((IfcPropertyTemplate)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertySetTemplate other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @HasPropertyTemplates)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertyTemplates)
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