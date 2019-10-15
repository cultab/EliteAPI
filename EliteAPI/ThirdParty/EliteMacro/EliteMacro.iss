; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "EliteMacro"
#define MyAppVersion "2.2.6.862"
#define MyAppPublisher "Somfic"
#define MyAppURL "https://github.com/EliteAPI/EliteAPI"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1862E147-EA1E-489A-9493-069DECA78088}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName=C:\Program Files (x86)\VoiceMacro\Plugins
DefaultGroupName={#MyAppName}
OutputBaseFilename=EliteMacro-setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "C:\Users\Lucas\Documents\GitHub\EliteAPI\EliteAPI\bin\Debug\netstandard2.0\EliteAPI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Lucas\Documents\GitHub\EliteAPI\EliteAPI\bin\Debug\netstandard2.0\EliteAPI.pdb"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

