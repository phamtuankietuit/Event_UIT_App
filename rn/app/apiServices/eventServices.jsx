import * as request from "../utils/request"

export const getHotEvents = async () => {
  try {
    const res = await request.getMethod(
      "events?PageSize=4&PageNumber=1&IsPublished=true",
      true
    )
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getEvents = async () => {
  try {
    const res = await request.getMethod("events?IsPublished=true", true)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getDetailEvent = async (id) => {
  try {
    const res = await request.getMethod("events/" + id, true)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const registerEvent = async (id, obj) => {
  try {
    const res = await request.postMethod(`events/${id}/register`, true, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
