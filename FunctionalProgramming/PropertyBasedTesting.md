

### Notes from John Hughes - Building on developers intuitions to create effective property based tests.
[John Hughes - Building on developers' intuitions](https://www.youtube.com/watch?v=NcJOiQlzlXQ)

__Process for creating property based tests__
1. Think of all the unit tests you would intuitively use to exercise the code under test.
2. Create a test data generator and then classify each piece of data with a label -> roughly corresponding to each unit test.
3. Use labelled examples to debug your labelling.
4. Once the labelling is correct gather statistics about which labels are being tested more that others.
5. Check the distribution of labels is satisfactory.
6. Check the coverage for each label and express the minimum required coverage as code.