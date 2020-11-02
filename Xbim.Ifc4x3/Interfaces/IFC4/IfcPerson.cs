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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ActorResource
{
	public partial class @IfcPerson : IIfcPerson
	{

		[CrossSchemaAttribute(typeof(IIfcPerson), 1)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcPerson.Identification 
		{ 
			get
			{
				if (!Identification.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(Identification.Value);
			} 
			set
			{
				Identification = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPerson), 2)]
		Ifc4.MeasureResource.IfcLabel? IIfcPerson.FamilyName 
		{ 
			get
			{
				if (!FamilyName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(FamilyName.Value);
			} 
			set
			{
				FamilyName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPerson), 3)]
		Ifc4.MeasureResource.IfcLabel? IIfcPerson.GivenName 
		{ 
			get
			{
				if (!GivenName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(GivenName.Value);
			} 
			set
			{
				GivenName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPerson), 4)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcPerson.MiddleNames 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLabel, Ifc4.MeasureResource.IfcLabel>(MiddleNames, 
					s => new Ifc4.MeasureResource.IfcLabel(s), 
					t => new MeasureResource.IfcLabel(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcPerson), 5)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcPerson.PrefixTitles 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLabel, Ifc4.MeasureResource.IfcLabel>(PrefixTitles, 
					s => new Ifc4.MeasureResource.IfcLabel(s), 
					t => new MeasureResource.IfcLabel(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcPerson), 6)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcPerson.SuffixTitles 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLabel, Ifc4.MeasureResource.IfcLabel>(SuffixTitles, 
					s => new Ifc4.MeasureResource.IfcLabel(s), 
					t => new MeasureResource.IfcLabel(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcPerson), 7)]
		IItemSet<IIfcActorRole> IIfcPerson.Roles 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcActorRole, IIfcActorRole>(Roles);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcPerson), 8)]
		IItemSet<IIfcAddress> IIfcPerson.Addresses 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcAddress, IIfcAddress>(Addresses);
			} 
		}
		IEnumerable<IIfcPersonAndOrganization> IIfcPerson.EngagedIn 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPersonAndOrganization>(e => (e.ThePerson as IfcPerson) == this, "ThePerson", this);
			} 
		}
	//## Custom code
	//##
	}
}