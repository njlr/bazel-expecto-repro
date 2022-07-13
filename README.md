# bazel-expecto-repro

The tests pass with MS Build:

```bash
dotnet run --project ./ratio.tests
```

But not with Bazel:

```bash
bazel test //...
```
