Student: Derya Ogus
Album: s30004

1. Fast-forward vs Merge commit:
   Fast-forward occurs when the target branch has no new commits since the feature branch was created.
   A merge commit is created when both branches have diverged (have different commits).
2. The merge in Task 5 was not fast-forward because main had a new commit (README)
   that feature-max didn't have, causing the branches to diverge.
3. Merge vs Rebase:
   - Merge preserves the exact history with branch structure, creating merge commits
     when branches diverged. It shows the true parallel development.
   - Rebase rewrites history by moving commits to the tip of the target branch,
     creating a linear history. It avoids merge commits but changes commit hashes.
4. Conflict Resolution:
   The conflict occurred in Program.cs where both branches modified the welcome message.