import {
  View,
  Text,
  Image,
  TouchableOpacity,
  ActivityIndicator,
  FlatList,
  RefreshControl,
  ToastAndroid,
} from "react-native"

import React, { useCallback, useEffect, useState } from "react"
import MyHeader from "../../components/MyHeader"
import EventItem from "../../components/EventItem"
import { useLocalSearchParams } from "expo-router"
import * as PageServices from "../../apiServices/pageServices"
import * as asyncStorage from "../../store/asyncStorage"

const showToastWithGravity = (msg) => {
  ToastAndroid.showWithGravity(msg, ToastAndroid.SHORT, ToastAndroid.CENTER)
}

const PageDetail = () => {
  const { id } = useLocalSearchParams()
  const [data, setData] = useState([])
  const [isLoading, setIsLoading] = useState(false)
  const [obj, setObj] = useState(null)
  const [refreshing, setRefreshing] = useState(false)

  const [buttonLoading, setButtonLoading] = useState(false)
  const [isFollowed, setIsFollowed] = useState(false)

  const handleFollow = async () => {
    const studentId = await asyncStorage.getIdAsync()
    setButtonLoading(true)

    const response = await PageServices.setFollow(id, {
      StudentId: studentId,
      UnitId: id,
    }).catch((error) => {
      showToastWithGravity("Có lỗi xảy ra")
      setButtonLoading(false)
    })

    if (response) {
      // Xử lý nếu response trả về
      setIsFollowed(!isFollowed)
      setButtonLoading(false)
    }
  }

  const onRefresh = useCallback(() => {
    setRefreshing(true)
    getEvents()
  }, [data])

  const getEvents = async () => {
    const studentId = await asyncStorage.getIdAsync()
    const response = await PageServices.getPage(id, {
      StudentId: studentId,
    }).catch((error) => {
      // xử lý lỗi
      if (error.response) {
        showToastWithGravity("Có lỗi xảy ra")
      }
    })

    if (response) {
      // Xử lý nếu response trả về
      setObj(response)
      setData(response.hostedEvent)
      setIsFollowed(response.isThisStudentFollowed)
    }
  }

  useEffect(() => {
    getEvents()
  }, [])

  return (
    <View className='relative flex-1'>
      <View className='absolute left-0 top-0 -z-10 h-[250px] w-full rounded-b-3xl bg-blue-500'></View>
      <MyHeader title={"Chi tiết trang"} />
      {
        <View className='w-full '>
          <View className='mx-auto mt-5 flex-row items-center justify-center rounded  bg-white p-3 shadow shadow-black'>
            <Image
              className='h-20 w-20 rounded-full'
              source={{
                uri: obj?.avatarUrl,
              }}
            ></Image>
            <View className='ml-2'>
              <Text className='w-[220px] text-base font-bold' numberOfLines={2}>
                {obj?.name}
              </Text>
              <Text className=''>{obj?.totalFollowers} người theo dõi</Text>
              <TouchableOpacity
                className={`${isFollowed ? "bg-blue-500" : "border border-blue-500 "} 
              mt-2 flex-row items-center justify-center rounded px-3 py-2`}
                onPress={() => handleFollow()}
              >
                {buttonLoading ? (
                  <ActivityIndicator
                    size='small'
                    color={isFollowed ? "white" : "#3b82f6"}
                  />
                ) : (
                  <Text
                    className={`font-medium ${isFollowed ? "text-white" : "text-blue-600"}`}
                  >
                    {isFollowed ? "Đang theo dõi" : "Theo dõi"}
                  </Text>
                )}
              </TouchableOpacity>
            </View>
          </View>
        </View>
      }

      <View className='mx-auto mt-2 min-w-[300px] max-w-[350px] items-center rounded bg-white p-3 shadow shadow-black'>
        <Text numberOfLines={5} ellipsizeMode='tail'>
          {obj?.description}
        </Text>
      </View>

      <View className='mt-3 flex-1'>
        {isLoading ? (
          <View className='h-full rounded-t-2xl bg-white px-3 py-2'>
            <ActivityIndicator size='large' color='#0000ff' />
          </View>
        ) : (
          <FlatList
            className='rounded-t-2xl bg-white px-3 py-2 pt-3 shadow shadow-black'
            data={data}
            keyExtractor={(item) => item.id}
            renderItem={({ item }) => (
              <EventItem item={item} universityUnit={obj} />
            )}
            scrollEventThrottle={16}
            showsVerticalScrollIndicator={false}
            refreshControl={
              <RefreshControl
                refreshing={refreshing}
                onRefresh={onRefresh}
                colors={["#3A57E8"]}
                tintColor='#3A57E8'
                progressViewOffset={20}
              />
            }
          />
        )}
      </View>
    </View>
  )
}

export default PageDetail
