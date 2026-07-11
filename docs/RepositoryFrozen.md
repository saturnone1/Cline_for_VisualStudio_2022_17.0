# Repository frozen after consolidation

Feature development in this repository is frozen. The canonical repository is:

```text
https://github.com/saturnone1/Cline_for_VisualStudio_2022_17.12
```

The canonical branch builds Visual Studio 2022 17.0 and 17.12 VSIX packages
from the same `src/` tree. Visual Studio version differences are restricted to
thin profiles under `packaging/vs2022-17.0` and `packaging/vs2022-17.12`.

This repository remains intact as recoverable history and as evidence for the
17.0 migration baseline. Do not copy feature fixes here. Apply compatibility
fixes in the canonical repository and run its dual-package build instead.
