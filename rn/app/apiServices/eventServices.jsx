import * as request from "../utils/request"

export const getHotEvents = async () => {
  try {
    const res = await request.getMethod("events?PageSize=4&PageNumber=1", false)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getEvents = async (params) => {
  try {
    const res = await request.getMethod("events?", false, params)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
