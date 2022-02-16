//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System;
using System.Linq;

using Rock.Attribute;
using Rock.Data;
using Rock.ViewModel;
using Rock.Web.Cache;

namespace Rock.Model
{
    /// <summary>
    /// WorkflowFormBuilderTemplate Service class
    /// </summary>
    public partial class WorkflowFormBuilderTemplateService : Service<WorkflowFormBuilderTemplate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowFormBuilderTemplateService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public WorkflowFormBuilderTemplateService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( WorkflowFormBuilderTemplate item, out string errorMessage )
        {
            errorMessage = string.Empty;

            if ( new Service<WorkflowType>( Context ).Queryable().Any( a => a.FormBuilderTemplateId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", WorkflowFormBuilderTemplate.FriendlyTypeName, WorkflowType.FriendlyTypeName );
                return false;
            }
            return true;
        }
    }

    /// <summary>
    /// WorkflowFormBuilderTemplate View Model Helper
    /// </summary>
    [DefaultViewModelHelper( typeof( WorkflowFormBuilderTemplate ) )]
    public partial class WorkflowFormBuilderTemplateViewModelHelper : ViewModelHelper<WorkflowFormBuilderTemplate, Rock.ViewModel.WorkflowFormBuilderTemplateViewModel>
    {
        /// <summary>
        /// Converts the model to a view model.
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <param name="currentPerson">The current person.</param>
        /// <param name="loadAttributes">if set to <c>true</c> [load attributes].</param>
        /// <returns></returns>
        public override Rock.ViewModel.WorkflowFormBuilderTemplateViewModel CreateViewModel( WorkflowFormBuilderTemplate model, Person currentPerson = null, bool loadAttributes = true )
        {
            if ( model == null )
            {
                return default;
            }

            var viewModel = new Rock.ViewModel.WorkflowFormBuilderTemplateViewModel
            {
                Id = model.Id,
                Guid = model.Guid,
                AllowPersonEntry = model.AllowPersonEntry,
                CompletionSettingsJson = model.CompletionSettingsJson,
                ConfirmationEmailSettingsJson = model.ConfirmationEmailSettingsJson,
                Description = model.Description,
                FormFooter = model.FormFooter,
                FormHeader = model.FormHeader,
                IsActive = model.IsActive,
                IsLoginRequired = model.IsLoginRequired,
                Name = model.Name,
                PersonEntrySettingsJson = model.PersonEntrySettingsJson,
                CreatedDateTime = model.CreatedDateTime,
                ModifiedDateTime = model.ModifiedDateTime,
                CreatedByPersonAliasId = model.CreatedByPersonAliasId,
                ModifiedByPersonAliasId = model.ModifiedByPersonAliasId,
            };

            AddAttributesToViewModel( model, viewModel, currentPerson, loadAttributes );
            ApplyAdditionalPropertiesAndSecurityToViewModel( model, viewModel, currentPerson, loadAttributes );
            return viewModel;
        }
    }


    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class WorkflowFormBuilderTemplateExtensionMethods
    {
        /// <summary>
        /// Clones this WorkflowFormBuilderTemplate object to a new WorkflowFormBuilderTemplate object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static WorkflowFormBuilderTemplate Clone( this WorkflowFormBuilderTemplate source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as WorkflowFormBuilderTemplate;
            }
            else
            {
                var target = new WorkflowFormBuilderTemplate();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Clones this WorkflowFormBuilderTemplate object to a new WorkflowFormBuilderTemplate object with default values for the properties in the Entity and Model base classes.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static WorkflowFormBuilderTemplate CloneWithoutIdentity( this WorkflowFormBuilderTemplate source )
        {
            var target = new WorkflowFormBuilderTemplate();
            target.CopyPropertiesFrom( source );

            target.Id = 0;
            target.Guid = Guid.NewGuid();
            target.ForeignKey = null;
            target.ForeignId = null;
            target.ForeignGuid = null;
            target.CreatedByPersonAliasId = null;
            target.CreatedDateTime = RockDateTime.Now;
            target.ModifiedByPersonAliasId = null;
            target.ModifiedDateTime = RockDateTime.Now;

            return target;
        }

        /// <summary>
        /// Copies the properties from another WorkflowFormBuilderTemplate object to this WorkflowFormBuilderTemplate object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this WorkflowFormBuilderTemplate target, WorkflowFormBuilderTemplate source )
        {
            target.Id = source.Id;
            target.AllowPersonEntry = source.AllowPersonEntry;
            target.CompletionSettingsJson = source.CompletionSettingsJson;
            target.ConfirmationEmailSettingsJson = source.ConfirmationEmailSettingsJson;
            target.Description = source.Description;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.FormFooter = source.FormFooter;
            target.FormHeader = source.FormHeader;
            target.IsActive = source.IsActive;
            target.IsLoginRequired = source.IsLoginRequired;
            target.Name = source.Name;
            target.PersonEntrySettingsJson = source.PersonEntrySettingsJson;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }

        /// <summary>
        /// Creates a view model from this entity
        /// </summary>
        /// <param name="model">The entity.</param>
        /// <param name="currentPerson" >The currentPerson.</param>
        /// <param name="loadAttributes" >Load attributes?</param>
        public static Rock.ViewModel.WorkflowFormBuilderTemplateViewModel ToViewModel( this WorkflowFormBuilderTemplate model, Person currentPerson = null, bool loadAttributes = false )
        {
            var helper = new WorkflowFormBuilderTemplateViewModelHelper();
            var viewModel = helper.CreateViewModel( model, currentPerson, loadAttributes );
            return viewModel;
        }

    }

}