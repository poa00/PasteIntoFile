//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasteIntoFile.Properties {
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
    internal class Resources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PasteIntoFile.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon app_icon {
            get {
                object obj = ResourceManager.GetObject("app_icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Paste Into File.
        /// </summary>
        internal static string app_title {
            get {
                return ResourceManager.GetString("app_title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Accept.
        /// </summary>
        internal static string str_accept {
            get {
                return ResourceManager.GetString("str_accept", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Hold shift key during save to show option window..
        /// </summary>
        internal static string str_autosave_balloontext {
            get {
                return ResourceManager.GetString("str_autosave_balloontext", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Clipboard saved to file.
        /// </summary>
        internal static string str_autosave_balloontitle {
            get {
                return ResourceManager.GetString("str_autosave_balloontitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Autosave (skip dialog).
        /// </summary>
        internal static string str_autosave_checkbox {
            get {
                return ResourceManager.GetString("str_autosave_checkbox", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Files are now automatically saved without prompting for filename and extension. Instead, the file created will be selected for renaming in the explorer window. To show the dialog again, run the PasteInfoFile executable without arguments or hold the SHIFT key while selecting the context menu entry..
        /// </summary>
        internal static string str_autosave_infotext {
            get {
                return ResourceManager.GetString("str_autosave_infotext", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string str_cancel {
            get {
                return ResourceManager.GetString("str_cancel", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Clear clipboard.
        /// </summary>
        internal static string str_clear_clipboard {
            get {
                return ResourceManager.GetString("str_clear_clipboard", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Paste into file.
        /// </summary>
        internal static string str_contextentry {
            get {
                return ResourceManager.GetString("str_contextentry", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Context menu entry.
        /// </summary>
        internal static string str_contextentry_checkbox {
            get {
                return ResourceManager.GetString("str_contextentry_checkbox", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Copy file content.
        /// </summary>
        internal static string str_contextentry_copyfromfile {
            get {
                return ResourceManager.GetString("str_contextentry_copyfromfile", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Replace with clipboard content.
        /// </summary>
        internal static string str_contextentry_replaceintofile {
            get {
                return ResourceManager.GetString("str_contextentry_replaceintofile", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Batch mode.
        /// </summary>
        internal static string str_continuous_mode {
            get {
                return ResourceManager.GetString("str_continuous_mode", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to In batch mode, clipboard contents will be saved instantly when new data is copied.
        ///
        ///Save current clipboard contents now?.
        /// </summary>
        internal static string str_continuous_mode_enabled_ask_savenow {
            get {
                return ResourceManager.GetString("str_continuous_mode_enabled_ask_savenow", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Please select a single file to copy file contents.
        /// </summary>
        internal static string str_copy_failed_not_single_file {
            get {
                return ResourceManager.GetString("str_copy_failed_not_single_file", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The file {0} contains data of unknown format which cannot be copied to the clipboard..
        /// </summary>
        internal static string str_copy_failed_unknown_format {
            get {
                return ResourceManager.GetString("str_copy_failed_unknown_format", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Edit template.
        /// </summary>
        internal static string str_edit_template {
            get {
                return ResourceManager.GetString("str_edit_template", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Clipboard contains no data convertable to extension {0} or conversion failed..
        /// </summary>
        internal static string str_error_cliboard_format_missmatch {
            get {
                return ResourceManager.GetString("str_error_cliboard_format_missmatch", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Exit.
        /// </summary>
        internal static string str_exit {
            get {
                return ResourceManager.GetString("str_exit", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Extension.
        /// </summary>
        internal static string str_extension {
            get {
                return ResourceManager.GetString("str_extension", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The file {0} already exists.
        ///Do you want to overwrite it?.
        /// </summary>
        internal static string str_file_exists {
            get {
                return ResourceManager.GetString("str_file_exists", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A directory with the same name already exists at {0}..
        /// </summary>
        internal static string str_file_exists_directory {
            get {
                return ResourceManager.GetString("str_file_exists_directory", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Filename.
        /// </summary>
        internal static string str_filename {
            get {
                return ResourceManager.GetString("str_filename", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Filename template.
        /// </summary>
        internal static string str_filename_template {
            get {
                return ResourceManager.GetString("str_filename_template", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid character: {0}.
        /// </summary>
        internal static string str_invalid_character {
            get {
                return ResourceManager.GetString("str_invalid_character", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Location.
        /// </summary>
        internal static string str_location {
            get {
                return ResourceManager.GetString("str_location", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Find this project on GitHub.
        /// </summary>
        internal static string str_main_info {
            get {
                return ResourceManager.GetString("str_main_info", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to https://github.com/eltos/PasteIntoFile.
        /// </summary>
        internal static string str_main_info_url {
            get {
                return ResourceManager.GetString("str_main_info_url", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Autostart registered.
        /// </summary>
        internal static string str_message_register_autostart_success {
            get {
                return ResourceManager.GetString("str_message_register_autostart_success", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Explorer context menu entry has been added.
        /// </summary>
        internal static string str_message_register_context_menu_success {
            get {
                return ResourceManager.GetString("str_message_register_context_menu_success", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Please run the application as administrator!.
        /// </summary>
        internal static string str_message_run_as_admin {
            get {
                return ResourceManager.GetString("str_message_run_as_admin", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Autostart unregistered.
        /// </summary>
        internal static string str_message_unregister_autostart_success {
            get {
                return ResourceManager.GetString("str_message_unregister_autostart_success", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Explorer context menu entry has been removed.
        /// </summary>
        internal static string str_message_unregister_context_menu_success {
            get {
                return ResourceManager.GetString("str_message_unregister_context_menu_success", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} saved.
        /// </summary>
        internal static string str_n_saved {
            get {
                return ResourceManager.GetString("str_n_saved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Clipboard is empty or contains unsupported data.
        /// </summary>
        internal static string str_noclip_text {
            get {
                return ResourceManager.GetString("str_noclip_text", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Open.
        /// </summary>
        internal static string str_open {
            get {
                return ResourceManager.GetString("str_open", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Open Paste Into File.
        /// </summary>
        internal static string str_open_paste_into_file {
            get {
                return ResourceManager.GetString("str_open_paste_into_file", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Preview.
        /// </summary>
        internal static string str_preview {
            get {
                return ResourceManager.GetString("str_preview", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to CSV preview.
        /// </summary>
        internal static string str_preview_csv {
            get {
                return ResourceManager.GetString("str_preview_csv", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Data Interchange preview.
        /// </summary>
        internal static string str_preview_dif {
            get {
                return ResourceManager.GetString("str_preview_dif", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to File list preview ({0} files and folders).
        /// </summary>
        internal static string str_preview_files {
            get {
                return ResourceManager.GetString("str_preview_files", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to HTML preview.
        /// </summary>
        internal static string str_preview_html {
            get {
                return ResourceManager.GetString("str_preview_html", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Image preview ({0}x{1} px).
        /// </summary>
        internal static string str_preview_image {
            get {
                return ResourceManager.GetString("str_preview_image", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Vector image preview.
        /// </summary>
        internal static string str_preview_image_vector {
            get {
                return ResourceManager.GetString("str_preview_image_vector", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Rich Text preview.
        /// </summary>
        internal static string str_preview_rtf {
            get {
                return ResourceManager.GetString("str_preview_rtf", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Scalable Vector Graphic preview.
        /// </summary>
        internal static string str_preview_svg {
            get {
                return ResourceManager.GetString("str_preview_svg", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Symbolic Link (SYLK) preview.
        /// </summary>
        internal static string str_preview_sylk {
            get {
                return ResourceManager.GetString("str_preview_sylk", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Text preview ({0} chars, {1} lines).
        /// </summary>
        internal static string str_preview_text {
            get {
                return ResourceManager.GetString("str_preview_text", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to URL preview.
        /// </summary>
        internal static string str_preview_url {
            get {
                return ResourceManager.GetString("str_preview_url", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Save.
        /// </summary>
        internal static string str_save {
            get {
                return ResourceManager.GetString("str_save", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Select a folder for saving this file .
        /// </summary>
        internal static string str_select_folder {
            get {
                return ResourceManager.GetString("str_select_folder", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Settings.
        /// </summary>
        internal static string str_settings {
            get {
                return ResourceManager.GetString("str_settings", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The template is used to format the filename. The following variables are supported:
        ///  {0} - Date and time
        ///  {1} - Save count in batch mode
        ///For details on the format specifiers &lt;a&gt;click here&lt;/a&gt;..
        /// </summary>
        internal static string str_template_edit_info {
            get {
                return ResourceManager.GetString("str_template_edit_info", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings.
        /// </summary>
        internal static string str_template_edit_info_url {
            get {
                return ResourceManager.GetString("str_template_edit_info_url", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Version {0}.
        /// </summary>
        internal static string str_version {
            get {
                return ResourceManager.GetString("str_version", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Update available: {0} ➜ {1}.
        /// </summary>
        internal static string str_version_update_available {
            get {
                return ResourceManager.GetString("str_version_update_available", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Enable autosave.
        /// </summary>
        internal static string str_wizard_autosave_button {
            get {
                return ResourceManager.GetString("str_wizard_autosave_button", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to You can configure Paste Into File to automatically save the file. When enabled, the dialog prompting for filename and extension is skipped and the file will be created and selected for renaming in the explorer window instead. To temporarily invert the setting, hold the SHIFT key when running Paste Into File. Note that the dialog is always shown when executing Paste Into File without command line arguments..
        /// </summary>
        internal static string str_wizard_autosave_info {
            get {
                return ResourceManager.GetString("str_wizard_autosave_info", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Automatically save file without prompt?.
        /// </summary>
        internal static string str_wizard_autosave_title {
            get {
                return ResourceManager.GetString("str_wizard_autosave_title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to By adding entries to the File Explorer context menu, you can quickly paste clipboard contents into files or copy file contents via right click..
        /// </summary>
        internal static string str_wizard_contextentry_info {
            get {
                return ResourceManager.GetString("str_wizard_contextentry_info", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Add context menu entries?.
        /// </summary>
        internal static string str_wizard_contextentry_title {
            get {
                return ResourceManager.GetString("str_wizard_contextentry_title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Finish setup.
        /// </summary>
        internal static string str_wizard_finish {
            get {
                return ResourceManager.GetString("str_wizard_finish", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Welcome to Paste Into File.
        /// </summary>
        internal static string str_wizard_title {
            get {
                return ResourceManager.GetString("str_wizard_title", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Autostart into tray.
        /// </summary>
        internal static string str_wizard_tray_autostart_button {
            get {
                return ResourceManager.GetString("str_wizard_tray_autostart_button", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to If enabled, Paste Into File is started on windows startup and keeps running in the system tray. This allows to call Paste Into File by pressing WIN+ALT+V (and WIN+ALT+C to copy file contents).
        ///In addition, you may enable clipboard patching. This monitors the clipboard and patches it automatically, so you can use CTRL+V in file explorer as usual.
        ///These setting will take effect on the next login..
        /// </summary>
        internal static string str_wizard_tray_info {
            get {
                return ResourceManager.GetString("str_wizard_tray_info", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Enable clipboard patching (experimental).
        /// </summary>
        internal static string str_wizard_tray_patching_button {
            get {
                return ResourceManager.GetString("str_wizard_tray_patching_button", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Enable autostart and hotkeys?.
        /// </summary>
        internal static string str_wizard_tray_title {
            get {
                return ResourceManager.GetString("str_wizard_tray_title", resourceCulture);
            }
        }
    }
}
