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
using Xbim.Ifc4x3.ProfileResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProfileResource
{
	[ExpressType("IfcCompositeProfileDef", 172)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeProfileDef : IfcProfileDef, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcCompositeProfileDef>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_profiles = new ItemSet<IfcProfileDef>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcProfileDef> _profiles;
		private IfcLabel? _label;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 2 }, new int [] { -1 }, 5)]
		public IItemSet<IfcProfileDef> @Profiles 
		{ 
			get 
			{
				if(_activated) return _profiles;
				Activate();
				return _profiles;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLabel? @Label 
		{ 
			get 
			{
				if(_activated) return _label;
				Activate();
				return _label;
			} 
			set
			{
				SetValue( v =>  _label = v, _label, value,  "Label", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_profiles.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 3: 
					_label = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Profiles)
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