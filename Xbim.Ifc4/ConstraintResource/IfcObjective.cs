// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcObjective
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcObjective : IIfcConstraint
	{
		IItemSet<IIfcConstraint> @BenchmarkValues { get; }
		IfcLogicalOperatorEnum? @LogicalAggregator { get;  set; }
		IfcObjectiveEnum @ObjectiveQualifier { get;  set; }
		IfcLabel? @UserDefinedQualifier { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ConstraintResource
{
	[ExpressType("IfcObjective", 518)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcObjective : IfcConstraint, IInstantiableEntity, IIfcObjective, IContainsEntityReferences, IEquatable<@IfcObjective>
	{
		#region IIfcObjective explicit implementation
		IItemSet<IIfcConstraint> IIfcObjective.BenchmarkValues { 
			get { return new Common.Collections.ProxyItemSet<IfcConstraint, IIfcConstraint>( @BenchmarkValues); } 
		}	
		IfcLogicalOperatorEnum? IIfcObjective.LogicalAggregator { 
 
			get { return @LogicalAggregator; } 
			set { LogicalAggregator = value;}
		}	
		IfcObjectiveEnum IIfcObjective.ObjectiveQualifier { 
 
			get { return @ObjectiveQualifier; } 
			set { ObjectiveQualifier = value;}
		}	
		IfcLabel? IIfcObjective.UserDefinedQualifier { 
 
			get { return @UserDefinedQualifier; } 
			set { UserDefinedQualifier = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObjective(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_benchmarkValues = new OptionalItemSet<IfcConstraint>( this, 0,  8);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcConstraint> _benchmarkValues;
		private IfcLogicalOperatorEnum? _logicalAggregator;
		private IfcObjectiveEnum _objectiveQualifier;
		private IfcLabel? _userDefinedQualifier;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 10)]
		public IOptionalItemSet<IfcConstraint> @BenchmarkValues 
		{ 
			get 
			{
				if(_activated) return _benchmarkValues;
				Activate();
				return _benchmarkValues;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 11)]
		public IfcLogicalOperatorEnum? @LogicalAggregator 
		{ 
			get 
			{
				if(_activated) return _logicalAggregator;
				Activate();
				return _logicalAggregator;
			} 
			set
			{
				SetValue( v =>  _logicalAggregator = v, _logicalAggregator, value,  "LogicalAggregator", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 12)]
		public IfcObjectiveEnum @ObjectiveQualifier 
		{ 
			get 
			{
				if(_activated) return _objectiveQualifier;
				Activate();
				return _objectiveQualifier;
			} 
			set
			{
				SetValue( v =>  _objectiveQualifier = v, _objectiveQualifier, value,  "ObjectiveQualifier", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public IfcLabel? @UserDefinedQualifier 
		{ 
			get 
			{
				if(_activated) return _userDefinedQualifier;
				Activate();
				return _userDefinedQualifier;
			} 
			set
			{
				SetValue( v =>  _userDefinedQualifier = v, _userDefinedQualifier, value,  "UserDefinedQualifier", 11);
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
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_benchmarkValues.InternalAdd((IfcConstraint)value.EntityVal);
					return;
				case 8: 
                    _logicalAggregator = (IfcLogicalOperatorEnum) System.Enum.Parse(typeof (IfcLogicalOperatorEnum), value.EnumVal, true);
					return;
				case 9: 
                    _objectiveQualifier = (IfcObjectiveEnum) System.Enum.Parse(typeof (IfcObjectiveEnum), value.EnumVal, true);
					return;
				case 10: 
					_userDefinedQualifier = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObjective other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@CreatingActor != null)
					yield return @CreatingActor;
				foreach(var entity in @BenchmarkValues)
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