# Frozen repository rules

- Do not implement features or architecture refactors in this repository.
- Use the `VS2022_17.12` repository as the canonical source for both 17.0 and 17.12 packages.
- Preserve this repository and its Git history for migration comparison and recovery.
- If a 17.0 compatibility issue is found, implement it as a thin profile or documented adapter in the canonical repository and validate both VSIX variants.
