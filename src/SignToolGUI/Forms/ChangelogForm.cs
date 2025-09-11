﻿using System;
using System.Windows.Forms;

namespace SignToolGUI.Forms
{
    public partial class ChangelogForm : Form
    {
        public ChangelogForm()
        {
            InitializeComponent();
        }

        private void ChangelogForm_Load(object sender, EventArgs e)
        {
            PopulateChangelog();
        }

        // Populate the changelog in the RichTextBox
        private void PopulateChangelog()
        {
            // Changelog content
            var changelogContent = " Version 2.0.0.0 (00-00-2025):\n\n" +
                                   " New Features\n" +
                                   " - Added certificate monitoring functionality with new CertificateMonitor class and CertificateStatus Form\n" +
                                   " - Introduced comprehensive timestamp server management system\n" +
                                   "   - New TimestampServerEditForm for adding and editing individual timestamp servers\n" +
                                   "   - New TimestampServerManagementForm for centralized server configuration management\n" +
                                   "   - Added TimestampServer and TimestampManager classes for server handling and orchestration\n" +
                                   "   - Dynamic interface adaptation: \"Timestamp Servers\" for PFX/Certificate Store and \"Endpoints\" for Trusted Signing\n" +
                                   " - Built-in timestamp server availability testing and health monitoring\n" +
                                   " - Support for server prioritization, enabling/disabling, and timeout configuration\n" +
                                   " - Added certificate type persistence - application now remembers your preferred signing method (Windows Certificate Store, PFX Certificate, or Trusted Signing)\n\n" +
                                   " User Interface Enhancements\n" +
                                   " - Enhanced MainForm UI with new menu options for certificate monitoring and timestamp server management\n" +
                                   " - Introduced color-coded alerts for certificate expiry in both Windows Certificate Store and PFX scenarios\n" +
                                   " - Improved certificate information display with better visual feedback\n" +
                                   " - Added intuitive forms for managing timestamp server configurations\n" +
                                   " - Context-aware UI labels that change based on signing type (Trusted Signing vs. traditional methods)\n\n" +
                                   " Security Improvements\n" +
                                   " - Major Security Enhancement: Completely redesigned password encryption system\n" +
                                   "   - Replaced hardcoded encryption keys with machine-specific key derivation\n" +
                                   "   - Upgraded from basic encryption to AES-256 with PBKDF2 key derivation (100,000 iterations)\n" +
                                   "   - Implemented automatic migration from old encryption format to new secure method\n" +
                                   "   - Added machine-specific entropy sources (hardware identifiers, system properties)\n" +
                                   "   - Passwords encrypted on one machine cannot be decrypted on another (intentional security feature)\n" +
                                   " - Enhanced certificate validation and password security handling\n\n" +
                                   " Architecture Improvements\n" +
                                   " - Refactored signing classes (SignerPfx, SignerThumbprint, SignerTrustedSigning) to inherit from new SignerBase abstract class\n" +
                                   " - Centralized common signing logic, reducing code redundancy and improving maintainability\n" +
                                   " - Added new SecurePasswordManager class for robust password encryption/decryption\n" +
                                   " - Enhanced certificate validation and monitoring capabilities\n" +
                                   " - Improved error handling and validation for certificate paths and passwords\n" +
                                   " - Better separation of concerns with dedicated security and configuration management classes\n\n" +
                                   " Performance & Reliability\n" +
                                   " - Implemented asynchronous operations for better application responsiveness\n" +
                                   " - Enhanced logging system for improved troubleshooting and debugging\n" +
                                   " - Added automatic failover to backup timestamp servers when primary servers are unavailable\n" +
                                   " - Improved stability when handling certificate operations and network-related timestamp failures\n" +
                                   " - Better configuration persistence and loading mechanisms\n\n" +
                                   " Bug Fixes\n" +
                                   " - Better error recovery for network-related timestamp failures\n" +
                                   " - Enhanced validation for certificate operations\n" +
                                   " - Improved stability in certificate monitoring scenarios\n" +
                                   " - Fixed configuration loading order to prevent UI overrides\n" +
                                   " - Better handling of corrupted or incompatible password data\n\n" +
                                   " Technical Details\n" +
                                   " - Enhanced compatibility with .NET Framework 4.8\n" +
                                   " - Improved machine-specific key generation using multiple entropy sources\n" +
                                   " - Added comprehensive error handling and logging for security operations\n" +
                                   " - Backward compatibility maintained through automatic password migration system\n\n" +
                                   "This release represents a major milestone in security and usability, significantly enhancing the reliability, user experience, and enterprise-readiness of the SignTool GUI. The new security architecture ensures that sensitive certificate passwords are protected with industry-standard encryption while maintaining seamless user experience through automatic migration and intelligent configuration management.\n\n" +
                                   " Version 1.4.0.0 (17-03-2025):\n" +
                                   " - Updated Trusted Signing from v0.1.103.0 to the latest v0.1.108.0\n" +
                                   " - The tool now only displays Code Signing certificates with a private key for selection\n" +
                                   " - Added a direct link to the Azure Portal to help you find your Trusted Signing accounts\n" +
                                   " - New option to enable or disable timestamping when signing (supported for .pfx and\n" +
                                   "   Certificate Store certificates)\n" +
                                   " - Improved error handling and logging\n" +
                                   " - Added support for more versions of the Windows SDK\n" +
                                   " - New \"Select All\" option for bulk selecting/unselecting files to sign\n" +
                                   " - Minor UI improvements for a better user experience\n\n" +
                                   " Version 1.3.0.0 (18-07-2024):\n" +
                                   " - Add support for Microsoft Trusted Signing\n" +
                                   " - Add check for if tool is code signed (via Windows API, valid or valid with my Code Signing\n" +
                                   "   Certificate via Thumbprint hosted on GitHub)\n" +
                                   " - Add multiple timestamp servers" +
                                   " - Add save to logfile\n" +
                                   " - Bug fixes\n" + 
                                   "   > Like Certificate Store certs will reset on every sign\n\n" +
                                   " Version 1.2.2.0 (04-07-2024):\n" +
                                   " - Add code to DPI aware and SignTool via API\n" +
                                   " - Add more status messages to statusstrip for file operations\n" +
                                   " - Performance tweaks\n" +
                                   " - Change arch for default signtool.exe\n" +
                                   " - GUI changes\n" +
                                   " - Bug fixes\n\n" +
                                   " Version 1.2.1.0 (09-08-2023):\n" +
                                   " - Major release\n" +
                                   " - Added feature to find if signtool.exe is installed on the computer\n" +
                                   " - UI updates\n" +
                                   " - Add new feature for reset interface\n" +
                                   " - Add new feature for counting files\n" +
                                   " - Bug fixes like certificate information not showing up if saved cert at startup\n" +
                                   " - Minor changes\n" +
                                   " - Update shipped signtool.exe to last v.\n" +
                                   " - Updated to.net 4.8\n\n" +
                                   " Version 1.2.0.0 (30-06-2022):\n" +
                                   " - Feature additions\n" +
                                   " - Addressed issues\n\n" +
                                   " Version 1.0.4.0 (31-05-2021):\n" +
                                   " - Significant changes of logic and signing\n" +
                                   " - Overhauled GUI\n\n" +
                                   " Version 1.0.3.0 (30-04-2021):\n" +
                                   " - Fixed some bugs when signing multiple files at once from a folder\n" +
                                   " - Fixed issue for ECC SHA512 bug\n" +
                                   " - Performance enhancements\n\n" +
                                   " Version 1.0.2.0 (31-03-2021):\n" +
                                   " - More features added\n" +
                                   " - Several fixes in GUI text\n" +
                                   " - Performance tweaks\n" +
                                   " - UI enhancements\n\n" +
                                   " Version 1.0.1.0 (21-01-2021):\n" +
                                   " - Initial updates\n" +
                                   " - Bug fixes\n\n" +
                                   " Version 1.0.0.0 (11-01-2021):\n" +
                                   " - First release";

            // Set the content in the RichTextBox control
            richTextBoxChangelog.Text = changelogContent;
        }
    }
}