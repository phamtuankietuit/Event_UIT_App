import * as request from "../utils/request"

export const createEvent = async (obj) => {
  try {
    const res = await request.postMethod("events", true, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getDetailEvent = async (id) => {
  try {
    const res = await request.getMethod(`events/${id}`, true)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const UpdatePost = async (id,obj) => {
  try {
    const res = await request.putMethod(`events/${id}`, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
