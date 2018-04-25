import numpy as np
import csv
import glob
import pandas as pd
import sys

# Provide Folder where training csv are present

argument1 = sys.argv[1]

filenames = glob.glob(argument1)

combined_csv = pd.concat([pd.read_csv(f) for f in filenames])
if (sys.argv.__len__() == 4):
    combined_csv["Verified"] = sys.argv[2]
    combined_csv.to_csv(sys.argv[3], index=False)
else:
    combined_csv.to_csv('./Merged/combined.csv', index=False)
