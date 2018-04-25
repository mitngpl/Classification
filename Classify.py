import numpy as np

from sklearn.decomposition import PCA

from sklearn import neighbors, datasets

from sklearn.cross_validation import train_test_split

from sklearn.ensemble import RandomForestClassifier

from sklearn.neighbors import KNeighborsClassifier
from sklearn.ensemble import BaggingClassifier

from sklearn.metrics import accuracy_score
from sklearn.metrics import confusion_matrix
from sklearn.svm import *
import seaborn as sns
import pandas as pd
import math
import matplotlib.pyplot as plt

import numpy as np

import pylab as pl
import csv
import glob
import pandas as pd
import sys



def getDataSet(fileName, isTrainData):
    if isTrainData:
        # get Train data
        dataSet = pd.read_csv(fileName,
                              usecols=[ 'ID', 'Colour _Name_', 'Colour colour 1', 'Colour colour 2',
                                       'Colour colour 3', 'Reflectance _Name_', 'Reflectance ambient factor',
                                       'Reflectance diffuse factor', 'Reflectance mirror factor',
                                       'Reflectance roughness','Reflectance specular factor',
                                        'Type_8 decal mode', 'Type_8 offset centre', 'Type_8 rotation',
                                        'Type_8 s offset', 'Type_8 s origin', 'Type_8 s reflect', 'Type_8 s scale', 'Type_8 t offset',
                                        'Type_8 t origin','Type_8 t reflect','Type_8 t scale','Group','Verified'])
    else:
        # get Test data
        dataSet = pd.read_csv(fileName,
                              usecols=[ 'ID', 'Colour _Name_', 'Colour colour 1', 'Colour colour 2',
                                       'Colour colour 3', 'Reflectance _Name_', 'Reflectance ambient factor',
                                       'Reflectance diffuse factor', 'Reflectance mirror factor',
                                       'Reflectance roughness','Reflectance specular factor',
                                        'Type_8 decal mode', 'Type_8 offset centre', 'Type_8 rotation',
                                        'Type_8 s offset', 'Type_8 s origin', 'Type_8 s reflect', 'Type_8 s scale',
                                        'Type_8 t offset',
                                        'Type_8 t origin', 'Type_8 t reflect', 'Type_8 t scale','Verified'])

    # Fill empty data
    dataSet['Colour colour 1'] = dataSet['Colour colour 1'].fillna(0)
    dataSet['Colour colour 1'] = dataSet['Colour colour 1'].astype(float)
    dataSet['Colour colour 2'] = dataSet['Colour colour 2'].fillna(0)
    dataSet['Colour colour 2'] = dataSet['Colour colour 2'].astype(float)
    dataSet['Colour colour 3'] = dataSet['Colour colour 3'].fillna(0)
    dataSet['Colour colour 3'] = dataSet['Colour colour 3'].astype(float)
    dataSet['Colour _Name_'] = dataSet['Colour _Name_'].fillna("-1")
    dataSet['Reflectance _Name_'] = dataSet['Reflectance _Name_'].fillna("-1")
    dataSet['Reflectance ambient factor'] = dataSet['Reflectance ambient factor'].fillna(0)
    dataSet['Reflectance diffuse factor'] = dataSet['Reflectance diffuse factor'].fillna(0)
    dataSet['Reflectance mirror factor'] = dataSet['Reflectance mirror factor'].fillna(0)
    dataSet['Reflectance roughness'] = dataSet['Reflectance roughness'].fillna(0)
    dataSet['Reflectance specular factor'] = dataSet['Reflectance specular factor'].fillna(0)
    dataSet['Type_8 decal mode'] = dataSet['Type_8 decal mode'].fillna(0)
    dataSet['Type_8 offset centre'] = dataSet['Type_8 offset centre'].fillna(1)
    dataSet['Type_8 rotation'] = dataSet['Type_8 rotation'].fillna(1)
    dataSet['Type_8 s offset'] = dataSet['Type_8 s offset'].fillna(1)
    dataSet['Type_8 s origin'] = dataSet['Type_8 s origin'].fillna(1)
    dataSet['Type_8 s reflect'] = dataSet['Type_8 s reflect'].fillna(1)
    dataSet['Type_8 s scale'] = dataSet['Type_8 s scale'].fillna(0)
    dataSet['Type_8 t offset'] = dataSet['Type_8 t offset'].fillna(1)
    dataSet['Type_8 t origin'] = dataSet['Type_8 t origin'].fillna(1)
    dataSet['Type_8 t reflect'] = dataSet['Type_8 t reflect'].fillna(1)
    dataSet['Type_8 t scale'] = dataSet['Type_8 t scale'].fillna(0)

    # Replace strings to Number
    cleanup_nums = {
        'Colour _Name_': {'Birch':0,'Blue Marble':1,'cherry':2,'chrome':3,'colour blend':4,'cubes':5,'fleck':6,'granite':7,'maple':8,'marble':9,'oak':10,'paving':11,
                        'pine':12,'plain':13,'simple wood':14,'solid clouds':15,'solid polka':16,'turbulent':17,'wood':18,'wrapped birch floor':19,'wrapped brick':20,
                        'wrapped brick bonds':21,'wrapped checker':22,'wrapped cherry floor':23,'Wrapped Diagonal':24,'wrapped filtered image':25,'wrapped grid':26,
                        'wrapped image':27,'wrapped maple floor':28,'wrapped oak floor':29,'wrapped paint splat':30,'wrapped pine floor':31,'wrapped polka':32,'wrapped roof tiles':33,
                        'wrapped textured brick':34,'wrapped wood floor':35,'wrapped s stripe':36}}

    dataSet.replace(cleanup_nums, inplace=True)

    cleanup_nums1 = {'Reflectance _Name_': {'blurred conductor':0,'blurred dielectric':1, 'blurred glass':2,'blurred mirror':3,
                    'car paint':4,'chrome 2D': 5,'conductor':6,'constant':7,'dielectic':8,'eye light plastic':9,'glass':10,
                    'glossy dielectric':11,'glossy glass':12,'glossy metal':13,'glossy metal':14,'glossy mirror':15,
                    'lit appearance':16,'matte':17,'metal':18,'mirror':19,'phong':20,'plastic':21,'shadow catcher':22,
                    'translucency': 23,'translucent plastic': 24,'wrapped anisotropic':25,'wrapped circular anisotropic':26,
                    'wrapped mirror map':27,'wrapped specular map':28,'wrapped woven anisotropic':29,'environment':30, 'dielectric':31}}

    dataSet.replace(cleanup_nums1, inplace=True)

    cleanup_nums1 = {
        'Group': {'Fabric': 0, 'Glass': 1, 'Laminate': 2, 'Leather': 3, 'Metal': 4, 'Mineral': 5, 'Paint': 6,
                  'Plastic': 7, 'Wood': 8,'Emitter':9,'Miscellaneous':10,'SolidSurface':11,'Carpet':12,'Wallpaper':13}}
    dataSet.replace(cleanup_nums1, inplace=True)

    if isTrainData:
        # Fill Train data - x
        dataSet = dataSet[dataSet.Verified != 0]
        X = dataSet.drop("Group", axis=1)
        X = X.drop("ID", axis=1)
        X = X.drop("Verified", axis=1)
        Y = dataSet['Group']
        return X, Y

    else:
        # Fill Test data - x_test
        dataSet = dataSet[dataSet.Verified != 1]
        X = dataSet
        X = X.drop("ID", axis=1)
        X = X.drop("Verified", axis=1)
        return X


#Train Data
#X, y = getDataSet('./Merged_Training_data/combined_training.csv',1)
argument1 = sys.argv[1]
X, y = getDataSet(argument1,1)
#print(X)

# Use different algorithms to predict the outcome
#clf = LinearSVC()
#clf = KNeighborsClassifier()
clf =  RandomForestClassifier(n_estimators=100,criterion="gini")
#clf = BaggingClassifier(n_estimators=100)


#fit model
clf.fit(X, y)

#Split Testdata in 80/20
#train_X, test_X, train_y,test_y = train_test_split(X,y,test_size=0.5)
#y__pred = clf.predict(train_X)
#print(accuracy_score(train_y,y__pred))

#print(clf.score(train_X,train_y))

X_Test = getDataSet(argument1, 0)
#print(X_Test)
#knownOutput = list(Y_True)
y__pred = list(clf.predict(X_Test))

print(y__pred)
#dimensions = list(X.columns[:])
#target = X.columns[:]
#
#Xcd = X[dimensions]
#Ycd = X[target]
#corr = Xcd.corr( )

#f,ax = plt.subplots(figsize=(10,8))
#sns.heatmap(corr, mask=np.zeros_like(corr,dtype=np.bool), cmap=sns.diverging_palette(220,10,as_cmap=True), square=True, ax=ax)
#plt.show()

#out = [i for i, j in zip(knownOutput, predictedOutput) if i == j]
#print(len(out))
#print(out)
#print(clf.score(X_Test, Y_True))
