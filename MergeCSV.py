import numpy as np
import csv
import glob
import pandas as pd
import sys

#Provide Folder where training csv are present

argumanet1 = sys.argv[1]

filenames = glob.glob(argumanet1)

combined_csv = pd.concat( [ pd.read_csv(f) for f in filenames ] )

# Output File Name
combined_csv.to_csv( "combined_training.csv", index=False )

