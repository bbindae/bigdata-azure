# This file demonstrate basic RDD operations

from pyspark import SparkContext
sc = SparkContext("local", "RDD samples")

words = sc.parallelize(["scala", "java", "c#", "vb.net", "hadoop", "ms-sql", "python", "objective-c", "c++", "unity"])

# count() : number of elements in the RDD is returned.
counts = words.count()
print("Number of elements in RDD: %i" % (counts))

