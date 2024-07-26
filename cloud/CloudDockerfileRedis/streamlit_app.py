import streamlit as st
from redis import Redis

@st.experimental_singleton
def get_redis():
    # Create a database connection object that points to the URL.
    return Redis(host="redis", port=6379)

"Hello world to this shared counter app"

redis = get_redis()

if st.button("Inc"):
    redis.incr("counter")

if st.button("Dec"):
    redis.decr("counter")

if st.button("Set to 0"):
    redis.set("counter", 0)

counter = int(redis.get("counter"))

st.write(f"Shared Counter: {counter}")