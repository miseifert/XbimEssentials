// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ApprovalResource
{
	public partial class @IfcApproval : IIfcApproval
	{

		[CrossSchemaAttribute(typeof(IIfcApproval), 1)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcApproval.Identifier 
		{ 
			get
			{
				if (!Identifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(Identifier.Value);
			} 
			set
			{
				Identifier = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 2)]
		Ifc4.MeasureResource.IfcLabel? IIfcApproval.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 3)]
		Ifc4.MeasureResource.IfcText? IIfcApproval.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 4)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcApproval.TimeOfApproval 
		{ 
			get
			{
				if (!TimeOfApproval.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(TimeOfApproval.Value);
			} 
			set
			{
				TimeOfApproval = value.HasValue ? 
					new DateTimeResource.IfcDateTime(value.Value) :  
					 new DateTimeResource.IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 5)]
		Ifc4.MeasureResource.IfcLabel? IIfcApproval.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
			set
			{
				Status = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 6)]
		Ifc4.MeasureResource.IfcLabel? IIfcApproval.Level 
		{ 
			get
			{
				if (!Level.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Level.Value);
			} 
			set
			{
				Level = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 7)]
		Ifc4.MeasureResource.IfcText? IIfcApproval.Qualifier 
		{ 
			get
			{
				if (!Qualifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Qualifier.Value);
			} 
			set
			{
				Qualifier = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 8)]
		IIfcActorSelect IIfcApproval.RequestingApproval 
		{ 
			get
			{
				if (RequestingApproval == null) return null;
				var ifcorganization = RequestingApproval as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = RequestingApproval as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = RequestingApproval as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					RequestingApproval = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					RequestingApproval = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					RequestingApproval = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					RequestingApproval = ifcpersonandorganization;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApproval), 9)]
		IIfcActorSelect IIfcApproval.GivingApproval 
		{ 
			get
			{
				if (GivingApproval == null) return null;
				var ifcorganization = GivingApproval as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = GivingApproval as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = GivingApproval as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					GivingApproval = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					GivingApproval = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					GivingApproval = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					GivingApproval = ifcpersonandorganization;
					return;
				}
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcApproval.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcRelAssociatesApproval> IIfcApproval.ApprovedObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesApproval>(e => (e.RelatingApproval as IfcApproval) == this, "RelatingApproval", this);
			} 
		}
		IEnumerable<IIfcResourceApprovalRelationship> IIfcApproval.ApprovedResources 
		{ 
			get
			{
				return Model.Instances.Where<IIfcResourceApprovalRelationship>(e => (e.RelatingApproval as IfcApproval) == this, "RelatingApproval", this);
			} 
		}
		IEnumerable<IIfcApprovalRelationship> IIfcApproval.IsRelatedWith 
		{ 
			get
			{
				return Model.Instances.Where<IIfcApprovalRelationship>(e => e.RelatedApprovals != null &&  e.RelatedApprovals.Contains(this), "RelatedApprovals", this);
			} 
		}
		IEnumerable<IIfcApprovalRelationship> IIfcApproval.Relates 
		{ 
			get
			{
				return Model.Instances.Where<IIfcApprovalRelationship>(e => (e.RelatingApproval as IfcApproval) == this, "RelatingApproval", this);
			} 
		}
	//## Custom code
	//##
	}
}