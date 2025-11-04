# cse210-ww-student-template
VINCENT TAIYE BALOGUN  ---- version of CSE 210.

This repository contains the starter code for many different projects. They are arranged folders by week. There is also an an empty sandbox project that can be used to play around with any concept you would like.




Meaning of Version Control
Version control is a system that records changes to files over time so you can recall specific versions later. For software projects, it tracks who changed what, when, and why—storing a history of changes to code, documentation, and other project files. This history lets you inspect previous states, compare versions, and restore files if something goes wrong.

A key benefit
multiple people can work on the same codebase simultaneously without overwriting each other’s work. Version control also provides an audit trail (who changed what and why), makes rollbacks simple when bugs are introduced, and enables experimental work via branches that won’t break the main code.

Example: how a software team uses it
 workflow: each developer creates a feature branch (e.g., feature/login). They work locally, commit incremental changes, push the branch to the shared repository, then open a pull request for review. Teammates review the code, suggest revisions, and once approved the branch is merged into main. If the new change causes a regression, the team can revert the merge or inspect the commit history to find the offending change and fix it quickly.

A common Git command (example)

git commit -m "Add login form and validation"


Explanation: git commit records staged changes into the local repository as a new snapshot (a commit). The -m flag supplies a short message describing the change. Commits are the basic units of history—small, well-described commits make it far easier to understand and revert changes later