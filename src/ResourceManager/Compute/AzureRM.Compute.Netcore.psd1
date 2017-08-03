﻿#
# Module manifest for module 'PSGet_AzureRM.Compute'
#
# Generated by: Microsoft Corporation
#
# Generated on: 5/5/2017
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '0.9.2'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = 'D4CB9989-9ED1-49C2-BACD-0F8DAF758671'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = '[PowerShell .Net Core] Microsoft Azure PowerShell - Compute service cmdlets for Azure Resource Manager.  Manages virtual machines, hosted services, and related resources in Azure Resource Manager'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = '4.5.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = '4.0'

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'AzureRM.Profile.Netcore'; ModuleVersion = '0.9.2'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
TypesToProcess = 'netcoreapp2.0\Microsoft.Azure.Commands.Compute.Types.ps1xml'

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'netcoreapp2.0\Microsoft.Azure.Commands.Compute.format.ps1xml', 
               'netcoreapp2.0\Microsoft.Azure.Commands.Compute.format.generated.ps1xml', 
               'netcoreapp2.0\Generated\Microsoft.Azure.Commands.Compute.Automation.format.generated.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('netcoreapp2.0\Microsoft.Azure.Commands.Compute.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Remove-AzureRmAvailabilitySet', 'Get-AzureRmAvailabilitySet', 
               'New-AzureRmAvailabilitySet', 'Update-AzureRmAvailabilitySet', 
               'Get-AzureRmVMExtensionImageType', 'Get-AzureRmVMExtensionImage', 
               'Get-AzureRmVMADDomainExtension', 'Set-AzureRmVMADDomainExtension', 
               'Get-AzureRmVMAEMExtension', 'Remove-AzureRmVMAEMExtension', 
               'Set-AzureRmVMAEMExtension', 'Test-AzureRmVMAEMExtension', 
               'Set-AzureRmVMBginfoExtension', 
               'Get-AzureRmVMCustomScriptExtension', 
               'Remove-AzureRmVMCustomScriptExtension', 
               'Set-AzureRmVMCustomScriptExtension', 
               'Get-AzureRmVMDiagnosticsExtension', 
               'Remove-AzureRmVMDiagnosticsExtension', 
               'Remove-AzureRmVmssDiagnosticsExtension', 
               'Set-AzureRmVMDiagnosticsExtension', 'Set-AzureRmVMExtension', 
               'Remove-AzureRmVMExtension', 'Get-AzureRmVMExtension', 
               'Get-AzureRmVMSqlServerExtension', 
               'New-AzureRmVMSqlServerAutoBackupConfig', 
               'New-AzureRmVMSqlServerAutoPatchingConfig', 
               'New-AzureRmVMSqlServerKeyVaultCredentialConfig', 
               'Remove-AzureRmVMSqlServerExtension', 
               'Set-AzureRmVMSqlServerExtension', 'Get-AzureRmVMImage', 
               'Get-AzureRmVMAccessExtension', 'Remove-AzureRmVMAccessExtension', 
               'Set-AzureRmVMAccessExtension', 'Get-AzureRmVMImageSku', 
               'Get-AzureRmVMImagePublisher', 'Get-AzureRmVMImageOffer', 
               'Get-AzureRmRemoteDesktopFile', 'Get-AzureRmVMUsage', 
               'Get-AzureRmVMSize', 'Save-AzureRmVMImage', 'Set-AzureRmVM', 
               'Add-AzureRmVMAdditionalUnattendContent', 
               'Add-AzureRmVMSshPublicKey', 'Add-AzureRmVMSecret', 
               'Remove-AzureRmVMSecret', 'Remove-AzureRmVMNetworkInterface', 
               'Remove-AzureRmVMDataDisk', 'Set-AzureRmVMBootDiagnostics', 
               'Set-AzureRmVMDataDisk', 'Set-AzureRmVMPlan', 
               'Set-AzureRmVMSourceImage', 'Set-AzureRmVMOSDisk', 
               'Get-AzureRmVMBootDiagnosticsData', 'Get-AzureRmVM', 
               'Update-AzureRmVM', 'Restart-AzureRmVM', 'New-AzureRmVM', 
               'Start-AzureRmVM', 'Stop-AzureRmVM', 'Remove-AzureRmVM', 
               'New-AzureRmVMConfig', 'Set-AzureRmVMOperatingSystem', 
               'Add-AzureRmVMDataDisk', 'Add-AzureRmVMNetworkInterface', 
               'Add-AzureRmVhd', 'Save-AzureRmVhd', 
               'Add-AzureRmContainerServiceAgentPoolProfile', 
               'New-AzureRmContainerServiceConfig', 
               'Remove-AzureRmContainerServiceAgentPoolProfile', 
               'New-AzureRmContainerService', 'Update-AzureRmContainerService', 
               'Remove-AzureRmContainerService', 'Get-AzureRmContainerService', 
               'Get-AzureRmVmssVM', 'Set-AzureRmVmssVM', 
               'Add-AzureRmVmssAdditionalUnattendContent', 
               'Add-AzureRmVmssExtension', 'Add-AzureRmVmssDataDisk', 
               'Add-AzureRmVmssNetworkInterfaceConfiguration', 
               'Add-AzureRmVmssSecret', 'Add-AzureRmVmssSshPublicKey', 
               'Add-AzureRmVmssWinRMListener', 'New-AzureRmVmssConfig', 
               'New-AzureRmVmssIpConfig', 'New-AzureRmVmssVaultCertificateConfig', 
               'Remove-AzureRmVmssExtension', 'Remove-AzureRmVmssDataDisk', 
               'Remove-AzureRmVmssNetworkInterfaceConfiguration', 
               'Set-AzureRmVmssOsProfile', 'Set-AzureRmVmssStorageProfile', 
               'New-AzureRmVmss', 'Update-AzureRmVmss', 'Stop-AzureRmVmss', 
               'Remove-AzureRmVmss', 'Get-AzureRmVmss', 'Get-AzureRmVmssSku', 
               'Set-AzureRmVmss', 'Restart-AzureRmVmss', 'Start-AzureRmVmss', 
               'Update-AzureRmVmssInstance', 'Get-AzureRmVMDscExtensionStatus', 
               'Publish-AzureRmVMDscConfiguration', 'Remove-AzureRmVMDscExtension', 
               'Set-AzureRmVMDscExtension', 'Get-AzureRmVMDscExtension', 
               'Add-AzureRmVmssDiagnosticsExtension', 'Get-AzureRmVMChefExtension', 
               'Remove-AzureRmVMChefExtension', 'Set-AzureRmVMChefExtension', 
               'Remove-AzureRmVMBackup', 'Disable-AzureRmVMDiskEncryption', 
               'Get-AzureRmVMDiskEncryptionStatus', 
               'Remove-AzureRmVMDiskEncryptionExtension', 
               'Set-AzureRmVMDiskEncryptionExtension', 
               'Set-AzureRmVMBackupExtension', 'New-AzureRmDisk', 
               'Update-AzureRmDisk', 'Get-AzureRmDisk', 'Remove-AzureRmDisk', 
               'Grant-AzureRmDiskAccess', 'Revoke-AzureRmDiskAccess', 
               'New-AzureRmDiskConfig', 'Set-AzureRmDiskDiskEncryptionKey', 
               'Set-AzureRmDiskImageReference', 'Set-AzureRmDiskKeyEncryptionKey', 
               'New-AzureRmDiskUpdateConfig', 
               'Set-AzureRmDiskUpdateDiskEncryptionKey', 
               'Set-AzureRmDiskUpdateImageReference', 
               'Set-AzureRmDiskUpdateKeyEncryptionKey', 'New-AzureRmSnapshot', 
               'Update-AzureRmSnapshot', 'Get-AzureRmSnapshot', 
               'Remove-AzureRmSnapshot', 'Grant-AzureRmSnapshotAccess', 
               'Revoke-AzureRmSnapshotAccess', 'New-AzureRmSnapshotConfig', 
               'Set-AzureRmSnapshotDiskEncryptionKey', 
               'Set-AzureRmSnapshotImageReference', 
               'Set-AzureRmSnapshotKeyEncryptionKey', 
               'New-AzureRmSnapshotUpdateConfig', 
               'Set-AzureRmSnapshotUpdateDiskEncryptionKey', 
               'Set-AzureRmSnapshotUpdateImageReference', 
               'Set-AzureRmSnapshotUpdateKeyEncryptionKey', 'New-AzureRmImage', 
               'Update-AzureRmImage', 'Get-AzureRmImage', 'Remove-AzureRmImage', 
               'New-AzureRmImageConfig', 'Set-AzureRmImageOsDisk', 
               'Add-AzureRmImageDataDisk', 'Remove-AzureRmImageDataDisk', 
               'ConvertTo-AzureRmVMManagedDisk'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = ''

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','Compute','IAAS','VM','VirtualMachine'

        # A URL to the license for this module.
        LicenseUri = 'https://raw.githubusercontent.com/Azure/azure-powershell/dev/LICENSE.txt'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Updated Set-AzureRmVMAEMExtension and Test-AzureRmVMAEMExtension cmdlets to support Premium managed disks
* Backup encryption settings for IaaS VMs and restore on failure
* ChefServiceInterval option is renamed to ChefDaemonInterval now. Old one will continue to work however.
* Remove duplicated DataDiskNames and NetworkInterfaceIDs properties from PS VM object.
  - Make DataDiskNames and NetworkInterfaceIDs parameters optional in Remove-AzureRmVMDataDisk and Remove-AzureRmVMNetworkInterface, respectively.
* Fix the piping issue of Get cmdlets when the Get cmdlets return a list object.
* Cmdlets that conflicted with RDFE cmdlets have been renamed. See issue https://github.com/Azure/azure-powershell/issues/2917 for more details
    - `New-AzureVMSqlServerAutoBackupConfig` has been renamed to `New-AzureRmVMSqlServerAutoBackupConfig`
    - `New-AzureVMSqlServerAutoPatchingConfig` has been renamed to `New-AzureRmVMSqlServerAutoPatchingConfig`
    - `New-AzureVMSqlServerKeyVaultCredentialConfig` has been renamed to `New-AzureRmVMSqlServerKeyVaultCredentialConfig`
'

        # External dependent modules of this module
        # ExternalModuleDependencies = ''

    } # End of PSData hashtable
    
 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

