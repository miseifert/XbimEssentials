// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.ApprovalResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ApprovalResource
{
	[ExpressType("IfcApprovalActorRelationship", 442)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApprovalActorRelationship : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcApprovalActorRelationship>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApprovalActorRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcActorSelect _actor;
		private IfcApproval _approval;
		private IfcActorRole _role;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcActorSelect @Actor 
		{ 
			get 
			{
				if(_activated) return _actor;
				Activate();
				return _actor;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _actor = v, _actor, value,  "Actor", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcApproval @Approval 
		{ 
			get 
			{
				if(_activated) return _approval;
				Activate();
				return _approval;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _approval = v, _approval, value,  "Approval", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcActorRole @Role 
		{ 
			get 
			{
				if(_activated) return _role;
				Activate();
				return _role;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _role = v, _role, value,  "Role", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_actor = (IfcActorSelect)(value.EntityVal);
					return;
				case 1: 
					_approval = (IfcApproval)(value.EntityVal);
					return;
				case 2: 
					_role = (IfcActorRole)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcApprovalActorRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Actor != null)
					yield return @Actor;
				if (@Approval != null)
					yield return @Approval;
				if (@Role != null)
					yield return @Role;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Approval != null)
					yield return @Approval;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}