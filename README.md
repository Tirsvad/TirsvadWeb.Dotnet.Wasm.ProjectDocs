[![downloads][downloads-shield]][downloads-url][![Contributors][contributors-shield]][contributors-url][![Forks][forks-shield]][forks-url][![Stargazers][stars-shield]][stars-url][![Issues][issues-shield]][issues-url][![License][license-shield]][license-url][![LinkedIn][linkedin-shield]][linkedin-url]

# ![Logo][Logo] TirsvadWeb.Wasm.ProjectDocs

<!-- If there is screenshots -->
<!--
![Screenshot1][screenshot1-url]
-->

## Table of Contents
- [Description](#description)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
    - [Clone the repo](#clone-the-repo)
- [Usage](#usage)
- [Troubleshooting](#troubleshooting)
- [Milestones](#milestones)
- [Notes](#notes)
- [📂 Folder Structure](#-folder-structure)
- [Contributing](#contributing)
- [Bug / Issue Reporting](#bug--issue-reporting)
- [License](#license)
- [Contact](#contact)
- [Acknowledgments](#acknowledgments)

## Description
A hub for applications projects documentation using Doxygen.
This project development is based on the report at [docs/report.md](docs/report.md)

## Features

## Getting Started

### Prerequisites
- Dotnet 9.0 or later
- Mssql server or sql server express

### Installation

#### Clone the repo
```bash
git clone https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs.git
cd Dotnet.Wasm.ProjectDocs
```

## Usage

## Troubleshooting

### Build errors may occur if path lengths exceed the maximum allowed by the operating system. To resolve this, consider cloning the repository to a location with a shorter path.

Using Group Policy Editor (Recommended for newer Windows versions)
1. Press `Win + R`, type `gpedit.msc`, and press Enter to open the Group Policy Editor.
1. Navigate to `Computer Configuration > Administrative Templates > System > Filesystem`.
1. Find and double-click on the policy named `Enable Win32 long paths`.
1. Set it to `Enabled`, then click `Apply` and `OK`.
1. Restart your computer for the changes to take effect.

PowerShell Method (Alternative)
1. Open PowerShell as an administrator.
1. Run the following command to enable long paths:
   ```powershell
   New-ItemProperty -Path "HKLM:\SYSTEM\CurrentControlSet\Control\FileSystem" -Name "LongPathsEnabled" -Value 1 -PropertyType DWORD -Force
   ```
1. Restart your computer for the changes to take effect.

## Milestones

### v0.1.0 Basic project setup
- [ ] Add project structure and initial setup
- [ ] Add authentication and authorization

### v0.2.0
- [ ] Implement user roles and permissions

### v0.3.0
- [ ] Index over projects

### v1.0.0 Initial release
- [ ] Initial release of the project with basic functionality

### Notes



## 📂 Folder Structure
```plaintext
src/
├── 🖥️ TirsvadWeb.Wasm.ProjectDocs.WebUI/                  # Blazor WebAssembly ASP.NET Core host project
│   ├── 👤 Components/Account/                             # Identity and account-related components
│   ├── 🗂️ Components/Layout/                              # Layout components
│   ├── 📄 Components/Pages/                               # Main app pages
│   └── ...                                                # Other folders/files
├── 🌐 TirsvadWeb.Wasm.ProjectDocs.WebUI.Client/           # Blazor WebAssembly client project
│   ├── 📄 Pages/                                          # Client-side pages
│   └── ...                                                # Other folders/files
├── 🏗️ TirsvadWeb.Wasm.ProjectDocs.Infrastructure/         # Infrastructure project
│   ├── 💾 Persistence/                                    # Database context, migrations, and persistence
│   │   └── 🧬 Migrations/                                 # Database migrations
│   └── ...                                                # Other folders/files
├── 🧠 TirsvadWeb.Wasm.ProjectDocs.Application/            # Application layer (business logic)
├── 🏷️ TirsvadWeb.Wasm.ProjectDocs.Domain/                 # Domain entities and logic
└── 🧪 tests/                                              # Test projects
```

## Contributing
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

See [CONTRIBUTING.md](CONTRIBUTING.md)

## Bug / Issue Reporting  
If you encounter a bug or have an issue to report, please follow these steps:  

1. **Go to the Issues Page**  
  Navigate to the [GitHub Issues page][githubIssue-url].  

2. **Click "New Issue"**  
  Click the green **"New Issue"** button to create a new issue.  

3. **Provide Details**  
  - **Title**: Write a concise and descriptive title for the issue.  
  - **Description**: Include the following details:  
    - Steps to reproduce the issue.  
    - Expected behavior.  
    - Actual behavior.  
    - Environment details (e.g., OS, .NET version, etc.).  
  - **Attachments**: Add screenshots, logs, or any other relevant files if applicable.  

4. **Submit the Issue**  
  Once all details are filled in, click **"Submit new issue"** to report it.  

## License
Distributed under the AGPL-3.0 [License][license-url].

## Contact
Jens Tirsvad Nielsen - [LinkedIn][linkedin-url]

## Acknowledgments
- [Copilot](https://copilot.microsoft.com/): Helping to create documentation.

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/TirsvadWeb/Dotnet.Wasm.ProjectDocs?style=for-the-badge
[contributors-url]: https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/TirsvadWeb/Dotnet.Wasm.ProjectDocs?style=for-the-badge
[forks-url]: https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/network/members
[stars-shield]: https://img.shields.io/github/stars/TirsvadWeb/Dotnet.Wasm.ProjectDocs?style=for-the-badge
[stars-url]: https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/stargazers
[issues-shield]: https://img.shields.io/github/issues/TirsvadWeb/Dotnet.Wasm.ProjectDocs?style=for-the-badge
[issues-url]: https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/issues
[license-shield]: https://img.shields.io/github/license/TirsvadWeb/Dotnet.Wasm.ProjectDocs?style=for-the-badge
[license-url]: https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/jens-tirsvad-nielsen-13b795b9/
[githubIssue-url]: https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/issues/
[repos-size-shield]: https://img.shields.io/github/repo-size/TirsvadWeb/Dotnet.Wasm.ProjectDocs?style=for-the-badg

[logo]: https://raw.githubusercontent.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/main/images/logo/32x32/logo.png

<!-- If there is example code -->
[example-url]: https://raw.githubusercontent.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/main/src/Example/Example.cs

<!-- If this is a Nuget package -->
[nuget-shield]: https://img.shields.io/nuget/dt/NugetPackageName?style=for-the-badge
[nuget-url]: https://www.nuget.org/packages/NugetPackageName/
<!-- If this is a downloadable package from github -->
[downloads-shield]: https://img.shields.io/github/downloads/TirsvadWeb/Dotnet.Wasm.ProjectDocs/total?style=for-the-badge
[downloads-url]: https://github.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/releases

<!-- If there is screenshots -->
[screenshot1]: https://raw.githubusercontent.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/main/images/small/Screenshot1.png
[screenshot1-url]: https://raw.githubusercontent.com/TirsvadWeb/Dotnet.Wasm.ProjectDocs/main/images/Screenshot1.png