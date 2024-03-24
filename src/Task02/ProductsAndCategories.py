import pyspark.sql.functions as F

products_df = spark.read.csv("products.csv", header=True)
categories_df = spark.read.csv("categories.csv", header=True)
product_categories_df = spark.read.csv("product_categories.csv", header=True)

joined_df = products_df.join(product_categories_df, on="ProductID", how="left") \
    .join(categories_df, on="CategoryID", how="left")

product_category_pairs_df = joined_df.select("ProductName", "CategoryName")

products_without_categories_df = joined_df.filter(F.col("CategoryName").isNull()) \
    .select("ProductName")

result_df = product_category_pairs_df.union(products_without_categories_df)
