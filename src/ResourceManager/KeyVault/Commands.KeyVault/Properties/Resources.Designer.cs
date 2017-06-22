﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.KeyVault.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.KeyVault.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add certificate.
        /// </summary>
        public static string AddCertificate {
            get {
                return ResourceManager.GetString("AddCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add certificate contact.
        /// </summary>
        public static string AddCertificateContact {
            get {
                return ResourceManager.GetString("AddCertificateContact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add key.
        /// </summary>
        public static string AddKey {
            get {
                return ResourceManager.GetString("AddKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Key Vault managed Storage Account.
        /// </summary>
        public static string AddManagedStorageAccount {
            get {
                return ResourceManager.GetString("AddManagedStorageAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Email argument specified, &apos;{1}&apos;, matches multiple objects in the Azure Active Directory tenant &apos;{2}&apos;. Please use -UserPrincipalName to narrow down the the filter to a single object. The TenantID displayed by the cmdlet &apos;Get-AzureRmContext&apos; is the current subscription&apos;s Azure Active directory..
        /// </summary>
        public static string ADObjectAmbiguous {
            get {
                return ResourceManager.GetString("ADObjectAmbiguous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving object ID from Azure Active Directory failed. {0}
        ///
        ///Please provide object ID for the user or service principle to set a vault access policy.
        ///You can find the object ID using Azure Active Directory Module for Windows PowerShell..
        /// </summary>
        public static string ADObjectIDRetrievalFailed {
            get {
                return ResourceManager.GetString("ADObjectIDRetrievalFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the Active Directory object &apos;{0}&apos; in tenant &apos;{1}&apos;. Please make sure that the user or application service principal you are authorizing is registered in the current subscription&apos;s Azure Active directory. The TenantID displayed by the cmdlet &apos;Get-AzureRmContext&apos; is the current subscription&apos;s Azure Active directory..
        /// </summary>
        public static string ADObjectNotFound {
            get {
                return ResourceManager.GetString("ADObjectNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;all&apos; permission is being deprecated and does not include the &apos;purge&apos; permission. &apos;Purge&apos; permission must be explicitly set..
        /// </summary>
        public static string AllPermissionExpansionWarning {
            get {
                return ResourceManager.GetString("AllPermissionExpansionWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No account found in the context. Please login using Login-AzureRMAccount..
        /// </summary>
        public static string ArmAccountNotFound {
            get {
                return ResourceManager.GetString("ArmAccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup key.
        /// </summary>
        public static string BackupKey {
            get {
                return ResourceManager.GetString("BackupKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backup key file &apos;{0}&apos; already exists..
        /// </summary>
        public static string BackupKeyFileAlreadyExists {
            get {
                return ResourceManager.GetString("BackupKeyFileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find backup key file &apos;{0}&apos;.
        /// </summary>
        public static string BackupKeyFileNotFound {
            get {
                return ResourceManager.GetString("BackupKeyFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup secret.
        /// </summary>
        public static string BackupSecret {
            get {
                return ResourceManager.GetString("BackupSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backup secret file &apos;{0}&apos; already exists..
        /// </summary>
        public static string BackupSecretFileAlreadyExists {
            get {
                return ResourceManager.GetString("BackupSecretFileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find backup secret file &apos;{0}&apos;.
        /// </summary>
        public static string BackupSecretFileNotFound {
            get {
                return ResourceManager.GetString("BackupSecretFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad Parameter Set Name.
        /// </summary>
        public static string BadParameterSetName {
            get {
                return ResourceManager.GetString("BadParameterSetName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find certificate file &apos;{0}&apos;..
        /// </summary>
        public static string CertificateFileNotFound {
            get {
                return ResourceManager.GetString("CertificateFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create certificate administrator.
        /// </summary>
        public static string CreateCertificateAdministrator {
            get {
                return ResourceManager.GetString("CreateCertificateAdministrator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create certificate organization.
        /// </summary>
        public static string CreateCertificateOrganization {
            get {
                return ResourceManager.GetString("CreateCertificateOrganization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create certificate policy.
        /// </summary>
        public static string CreateCertificatePolicy {
            get {
                return ResourceManager.GetString("CreateCertificatePolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create key vault.
        /// </summary>
        public static string CreateKeyVault {
            get {
                return ResourceManager.GetString("CreateKeyVault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find deleted vault &apos;{0}&apos; in location &apos;{1}&apos;.
        /// </summary>
        public static string DeletedVaultNotFound {
            get {
                return ResourceManager.GetString("DeletedVaultNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite File ?.
        /// </summary>
        public static string FileOverwriteCaption {
            get {
                return ResourceManager.GetString("FileOverwriteCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite existing file at &apos;{0}&apos; ?.
        /// </summary>
        public static string FileOverwriteMessage {
            get {
                return ResourceManager.GetString("FileOverwriteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BYOK key can not be imported as software key.
        /// </summary>
        public static string ImportByokAsSoftkeyError {
            get {
                return ResourceManager.GetString("ImportByokAsSoftkeyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import certificate.
        /// </summary>
        public static string ImportCertificate {
            get {
                return ResourceManager.GetString("ImportCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid application Id..
        /// </summary>
        public static string InvalidApplicationId {
            get {
                return ResourceManager.GetString("InvalidApplicationId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid AzureEnvironment..
        /// </summary>
        public static string InvalidAzureEnvironment {
            get {
                return ResourceManager.GetString("InvalidAzureEnvironment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current subscription has been designated. Use Set-AzureRmContext -SubscriptionName &lt;subscriptionName&gt; to set the current subscription..
        /// </summary>
        public static string InvalidCurrentSubscription {
            get {
                return ResourceManager.GetString("InvalidCurrentSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key attributes.
        /// </summary>
        public static string InvalidKeyAttributes {
            get {
                return ResourceManager.GetString("InvalidKeyAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid &apos;{0}&apos; key blob..
        /// </summary>
        public static string InvalidKeyBlob {
            get {
                return ResourceManager.GetString("InvalidKeyBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid KeyBundle..
        /// </summary>
        public static string InvalidKeyBundle {
            get {
                return ResourceManager.GetString("InvalidKeyBundle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not create given key material in specified destination..
        /// </summary>
        public static string InvalidKeyDestination {
            get {
                return ResourceManager.GetString("InvalidKeyDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key identifier.
        /// </summary>
        public static string InvalidKeyIdentifier {
            get {
                return ResourceManager.GetString("InvalidKeyIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key name..
        /// </summary>
        public static string InvalidKeyName {
            get {
                return ResourceManager.GetString("InvalidKeyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key uri &apos;{0}&apos;..
        /// </summary>
        public static string InvalidKeyUri {
            get {
                return ResourceManager.GetString("InvalidKeyUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key vault managed storage acccount name..
        /// </summary>
        public static string InvalidManagedStorageAccountName {
            get {
                return ResourceManager.GetString("InvalidManagedStorageAccountName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid number of certificates..
        /// </summary>
        public static string InvalidNumberOfCertificates {
            get {
                return ResourceManager.GetString("InvalidNumberOfCertificates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse ObjectId into Guid..
        /// </summary>
        public static string InvalidObjectIdSyntax {
            get {
                return ResourceManager.GetString("InvalidObjectIdSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Sas permission &apos;{0}&apos;..
        /// </summary>
        public static string InvalidSasPermission {
            get {
                return ResourceManager.GetString("InvalidSasPermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret attributes.
        /// </summary>
        public static string InvalidSecretAttributes {
            get {
                return ResourceManager.GetString("InvalidSecretAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret identifier.
        /// </summary>
        public static string InvalidSecretIdentifier {
            get {
                return ResourceManager.GetString("InvalidSecretIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret name..
        /// </summary>
        public static string InvalidSecretName {
            get {
                return ResourceManager.GetString("InvalidSecretName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid secret uri &apos;{0}&apos;..
        /// </summary>
        public static string InvalidSecretUri {
            get {
                return ResourceManager.GetString("InvalidSecretUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No subscription is currently selected. Use Set-AzureRmContext to activate a subscription..
        /// </summary>
        public static string InvalidSelectedSubscription {
            get {
                return ResourceManager.GetString("InvalidSelectedSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Azure credentials have not been set up or have expired, please run Login-AzureRmAccount to set up your Azure credentials..
        /// </summary>
        public static string InvalidSubscriptionState {
            get {
                return ResourceManager.GetString("InvalidSubscriptionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tag format. Expect @{Name = &quot;tagName&quot;} or @{Name = &quot;tagName&quot;; Value = &quot;tagValue&quot;}.
        /// </summary>
        public static string InvalidTagFormat {
            get {
                return ResourceManager.GetString("InvalidTagFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid vault name..
        /// </summary>
        public static string InvalidVaultName {
            get {
                return ResourceManager.GetString("InvalidVaultName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid vault uri &apos;{0}&apos;. Vault uri must contain valid dns host name with domain suffix &apos;{1}&apos;..
        /// </summary>
        public static string InvalidVaultUri {
            get {
                return ResourceManager.GetString("InvalidVaultUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not find key file &apos;{0}&apos;..
        /// </summary>
        public static string KeyFileNotFound {
            get {
                return ResourceManager.GetString("KeyFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no default user account associated with this subscription. Certificate accounts are not supported with Azure Key Vault..
        /// </summary>
        public static string NoDefaultUserAccount {
            get {
                return ResourceManager.GetString("NoDefaultUserAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No tenant found in the context.  Please ensure that the credentials you provided are authorized to access an Azure subscription, then run Login-AzureRMAccount to login..
        /// </summary>
        public static string NoTenantInContext {
            get {
                return ResourceManager.GetString("NoTenantInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid permissions to {0}. The list contains &quot;all&quot; along with other permissions. Please remove &quot;all&quot; from the list or include only &quot;all&quot; in the list..
        /// </summary>
        public static string PermissionSetIncludesAllPlusOthers {
            get {
                return ResourceManager.GetString("PermissionSetIncludesAllPlusOthers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one permission should be selected for key access or secret access..
        /// </summary>
        public static string PermissionsNotSpecified {
            get {
                return ResourceManager.GetString("PermissionsNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove vault &apos;{0}&apos; forever..
        /// </summary>
        public static string PurgeVaultWarning {
            get {
                return ResourceManager.GetString("PurgeVaultWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Purge vault.
        /// </summary>
        public static string PurgeVaultWhatIfMessage {
            get {
                return ResourceManager.GetString("PurgeVaultWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recover key.
        /// </summary>
        public static string RecoverKey {
            get {
                return ResourceManager.GetString("RecoverKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recover secret.
        /// </summary>
        public static string RecoverSecret {
            get {
                return ResourceManager.GetString("RecoverSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recover vault.
        /// </summary>
        public static string RecoverVault {
            get {
                return ResourceManager.GetString("RecoverVault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to regenerate &apos;{0}&apos; of storage account &apos;{1}&apos; and make it an active key of Key Vault managed Storage Account..
        /// </summary>
        public static string RegenerateManagedStorageAccountKeyWarning {
            get {
                return ResourceManager.GetString("RegenerateManagedStorageAccountKeyWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Regenerate &apos;{0}&apos;.
        /// </summary>
        public static string RegenerateManagedStorageAccountKeyWhatIfMessage {
            get {
                return ResourceManager.GetString("RegenerateManagedStorageAccountKeyWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove certificate contact.
        /// </summary>
        public static string RemoveCertificateContact {
            get {
                return ResourceManager.GetString("RemoveCertificateContact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove certificate issuer.
        /// </summary>
        public static string RemoveCertificateIssuer {
            get {
                return ResourceManager.GetString("RemoveCertificateIssuer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove certificate operation.
        /// </summary>
        public static string RemoveCertificateOperation {
            get {
                return ResourceManager.GetString("RemoveCertificateOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove certificate &apos;{0}&apos;..
        /// </summary>
        public static string RemoveCertWarning {
            get {
                return ResourceManager.GetString("RemoveCertWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove certificate.
        /// </summary>
        public static string RemoveCertWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveCertWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to purge key &apos;{0}&apos;..
        /// </summary>
        public static string RemoveDeletedKeyWarning {
            get {
                return ResourceManager.GetString("RemoveDeletedKeyWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Purge key.
        /// </summary>
        public static string RemoveDeletedKeyWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveDeletedKeyWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to purge secret &apos;{0}&apos;..
        /// </summary>
        public static string RemoveDeletedSecretWarning {
            get {
                return ResourceManager.GetString("RemoveDeletedSecretWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Purge secret.
        /// </summary>
        public static string RemoveDeletedSecretWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveDeletedSecretWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove key &apos;{0}&apos;..
        /// </summary>
        public static string RemoveKeyWarning {
            get {
                return ResourceManager.GetString("RemoveKeyWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove key.
        /// </summary>
        public static string RemoveKeyWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveKeyWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove managed storage account &apos;{0}&apos;.
        /// </summary>
        public static string RemoveManagedStorageAccountWarning {
            get {
                return ResourceManager.GetString("RemoveManagedStorageAccountWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove managed storage account.
        /// </summary>
        public static string RemoveManagedStorageAccountWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveManagedStorageAccountWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove managed storage sas definition &apos;{0}&apos;.
        /// </summary>
        public static string RemoveManagedStorageSasDefinitionWarning {
            get {
                return ResourceManager.GetString("RemoveManagedStorageSasDefinitionWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove managed storage sas definition.
        /// </summary>
        public static string RemoveManagedStorageSasDefinitionWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveManagedStorageSasDefinitionWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove secret &apos;{0}&apos;.
        /// </summary>
        public static string RemoveSecretWarning {
            get {
                return ResourceManager.GetString("RemoveSecretWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove secret.
        /// </summary>
        public static string RemoveSecretWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveSecretWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove vault access policy.
        /// </summary>
        public static string RemoveVaultAccessPolicy {
            get {
                return ResourceManager.GetString("RemoveVaultAccessPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove vault &apos;{0}&apos;..
        /// </summary>
        public static string RemoveVaultWarning {
            get {
                return ResourceManager.GetString("RemoveVaultWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove vault.
        /// </summary>
        public static string RemoveVaultWhatIfMessage {
            get {
                return ResourceManager.GetString("RemoveVaultWhatIfMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore key.
        /// </summary>
        public static string RestoreKey {
            get {
                return ResourceManager.GetString("RestoreKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restore secret.
        /// </summary>
        public static string RestoreSecret {
            get {
                return ResourceManager.GetString("RestoreSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set certificate attribute.
        /// </summary>
        public static string SetCertificateAttributes {
            get {
                return ResourceManager.GetString("SetCertificateAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set certificate issuer.
        /// </summary>
        public static string SetCertificateIssuer {
            get {
                return ResourceManager.GetString("SetCertificateIssuer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set certificate policy.
        /// </summary>
        public static string SetCertificatePolicy {
            get {
                return ResourceManager.GetString("SetCertificatePolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set key attribute.
        /// </summary>
        public static string SetKeyAttribute {
            get {
                return ResourceManager.GetString("SetKeyAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Key Vault managed Storage Account attribute.
        /// </summary>
        public static string SetManagedStorageAccountKeysAttribute {
            get {
                return ResourceManager.GetString("SetManagedStorageAccountKeysAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Key Vault managed Storage SAS definition.
        /// </summary>
        public static string SetManagedStorageSasDefinition {
            get {
                return ResourceManager.GetString("SetManagedStorageSasDefinition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set secret.
        /// </summary>
        public static string SetSecret {
            get {
                return ResourceManager.GetString("SetSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set  secret attribute.
        /// </summary>
        public static string SetSecretAttribute {
            get {
                return ResourceManager.GetString("SetSecretAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set vault access policy.
        /// </summary>
        public static string SetVaultAccessPolicy {
            get {
                return ResourceManager.GetString("SetVaultAccessPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop certificate operation.
        /// </summary>
        public static string StopCertificateOperation {
            get {
                return ResourceManager.GetString("StopCertificateOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key vault cmdlet does not support account type &apos;{0}&apos;..
        /// </summary>
        public static string UnsupportedAccountType {
            get {
                return ResourceManager.GetString("UnsupportedAccountType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file format of &apos;{0}&apos; is not supported..
        /// </summary>
        public static string UnsupportedFileFormat {
            get {
                return ResourceManager.GetString("UnsupportedFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified vault already exists..
        /// </summary>
        public static string VaultAlreadyExists {
            get {
                return ResourceManager.GetString("VaultAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access policy is not set. No user or application have access permission to use this vault. This can happen if the vault was created by a service principal. Please use Set-AzureRmKeyVaultAccessPolicy to set access policies..
        /// </summary>
        public static string VaultNoAccessPolicyWarning {
            get {
                return ResourceManager.GetString("VaultNoAccessPolicyWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find vault &apos;{0}&apos; in resource group &apos;{1}&apos;..
        /// </summary>
        public static string VaultNotFound {
            get {
                return ResourceManager.GetString("VaultNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one of -EnabledForDeployment, -EnabledForTemplateDeployment, or -EnabledForDiskEncryption must be specified..
        /// </summary>
        public static string VaultPermissionFlagMissing {
            get {
                return ResourceManager.GetString("VaultPermissionFlagMissing", resourceCulture);
            }
        }
    }
}
